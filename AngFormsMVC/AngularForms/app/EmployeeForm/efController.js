angularFormsApp.controller('efController', function efController($scope, DataService) {
    $scope.employee = DataService.employee;

    $scope.departments = [
    "Engineering",
    "Procurement",
    "Finance",
    "Administration"
    ];

    $scope.submitForm = function () {

    }
});