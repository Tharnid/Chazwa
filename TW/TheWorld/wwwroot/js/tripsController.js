(function () {
    'use strict';

    // getting the module
    angular
        .module('app-trips')
        .controller('tripsController', tripsController);

    // tripsController.$inject = ['$location']; 

    function tripsController($location) {
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

        vm.addTrip = function () {
            //alert(vm.newTrip.name);

            vm.trips.push({ name: vm.newTrip.name, created: new Date() });
        };

        // vm.name = "Tharnid";


        //vm.title = 'tripsController';

        //activate();

        //function activate() { }



    }
})();
