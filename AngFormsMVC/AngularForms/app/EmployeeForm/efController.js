
angularFormsApp.controller('efController',
    function efController($scope, $window, $routeParams, $modalInstance, DataService) {

        if ($routeParams.id)
            $scope.employee = DataService.getEmployee($routeParams.id);
        else
            $scope.employee = { id: 0 };

        $scope.editableEmployee = angular.copy($scope.employee);

        $scope.departments = [
            "Engineering",
            "Procurement",
            "Finance",
            "Administration"
        ];

        $scope.programmingLanguages = [
            "C",
            "C++",
            "C#",
            "Clojure",
            "Elixir",
            "F#",
            "JavaScript",
            "PHP"
        ];

        $scope.submitForm = function () {

            if ($scope.editableEmployee.id == 0) {
                // insert new employee
                DataService.insertEmployee($scope.editableEmployee);
            }
            else {
                // update the employee
                DataService.updateEmployee($scope.editableEmployee);
            }

            $scope.employee = angular.copy($scope.editableEmployee);
            // $window.history.back();

            $modalInstance.close();
        };

        $scope.cancelForm = function () {
            //$window.history.back();

            $modalInstance.dismiss();
        };

    });