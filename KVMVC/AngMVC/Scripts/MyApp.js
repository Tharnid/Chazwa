(function() {

    // Create the module
    var app = angular.module('MyApp', ['ng-Route']); // will use ng route when we will implement routing


    // Create the controller
    app.conroller('HomeController', function($scope) { // scope is used to share data
        $scope.Message = "Hello, this is an Angular controller!!!";
    });
})();