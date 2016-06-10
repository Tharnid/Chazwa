(function () {
    'use strict';

    // getting the module
    angular
        .module('app-trips')
        .controller('tripsController', tripsController);

    // tripsController.$inject = ['$location']; 

    function tripsController($http) {
        /* jshint validthis:true */
        var vm = this;

        vm.trips = [
            {
                name: "US Trip",
                created: new Date()
            },
            {
                name: "World Trip",
                created: new Date()
            }
        ];

        vm.newTrip = {};

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/trips")
            .then(function (response) {
                // Success
                angular.copy(response.data, vm.trips);
            }, function (error) {
                // Fail
                vm.errorMessage = "Your shit is jacked...yo!!! : " + error;
            })
            .finally(function () {
                // vm.isBusy = false;
            });

        vm.addTrip = function () {
            vm.isBusy = true;
            vm.errorMessage = "";
            //alert(vm.newTrip.name);

            // vm.trips.push({ name: vm.newTrip.name, created: new Date() });

            vm.isBusy = true;

            $http.post("/api/trips", vm.newTrip)
                .then(function (response) {
                    // success
                    vm.trips.push(response.data);
                    vm.newTrip = {};
                }, function (error) {
                    // Fail
                    vm.errorMessage = " Failed to create yo trip man!!!: " + error;
                })
                .finally(function () {
                    // clear isBusy flag
                    vm.isBusy = false;
                });
        };

        // vm.name = "Tharnid";


        //vm.title = 'tripsController';

        //activate();

        //function activate() { }



    }
})();
