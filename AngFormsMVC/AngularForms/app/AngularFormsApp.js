
//var angularFormsApp = angular.module('angularFormsApp', ["ngRoute", "ui.bootstrap"]);  // its not $uibModal instead of $Modal

//angularFormsApp.config(function ($routeProvider) {
//    $routeProvider
//        .when("/home", {
//            templateUrl: "app/Home.html",
//            controller: "HomeController"
//        })
//        .when("/newEmployeeForm", {
//            templateUrl: "app/EmployeeForm/efTemplate.html",
//            controller: "efController"
//        })
//        .when("/updateEmployeeForm/:id", {
//            templateUrl: "app/EmployeeForm/efTemplate.html",
//            controller: "efController"
//        })
//        .otherwise({
//            redirectTo: "/home"
//        });
//});

//angularFormsApp.controller("HomeController",
//    function ($scope, $location, $uibModal, DataService) {

//        $scope.showCreateEmployeeForm = function () {
//            // $location.path('/newEmployeeForm');

//            $uibModal.open({
//                templateUrl: 'app/EmployeeForm/efTemplate.html',
//                controller: 'efController'
//            });
//        };

//        $scope.showUpdateEmployeeForm = function (id) {
//            $location.path('/updateEmployeeForm/' + id)
//        };

//    });


var angularFormsApp = angular.module('angularFormsApp', ["ngRoute", "ui.bootstrap"]);

angularFormsApp.config(function ($routeProvider) {
    $routeProvider
        .when("/home", {
            templateUrl: "app/Home.html",
            controller: "HomeController"
        })
        .when("/newEmployeeForm", {
            templateUrl: "app/EmployeeForm/efTemplate.html",
            controller: "efController"
        })
        .when("/updateEmployeeForm/:id", {
            templateUrl: "app/EmployeeForm/efTemplate.html",
            controller: "efController"
        })
        .otherwise({
            redirectTo: "/home"
        });
});

angularFormsApp.controller("HomeController",
    function ($scope, $location, DataService) {

        $scope.showCreateEmployeeForm = function () {
            $location.path('/newEmployeeForm');
        };

        $scope.showUpdateEmployeeForm = function (id) {
            $location.path('/updateEmployeeForm/' + id)
        };

    });
