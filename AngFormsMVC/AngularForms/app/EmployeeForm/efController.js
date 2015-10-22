angularFormsApp.controller('efController',
    function efController($scope, $window, DataService) {

        $scope.employee = DataService.employee;

        $scope.editableEmployee = angular.copy($scope.employee);

        $scope.departments = [
            "Engineering",
            "Procurement",
            "Finance",
            "Administration"
        ];

        $scope.submitForm = function () {
            $scope.employee = angular.copy($scope.editableEmployee);
            $window.history.back();  // naviagates to previous page
        };

        $scope.cancelForm = function () {
            $window.history.back();
        };

    });