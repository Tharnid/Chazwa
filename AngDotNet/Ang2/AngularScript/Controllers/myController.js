app.controller('ctrlCustomer', function ($scope, $http) {

    // Call to Web API
    var Url = '/api/Customer/getAllCustomers'

    $http({
        method: 'GET',
        url: Url
    }).success(function (customerList) {
        $scope.AllCustomer = customerList;
    }).error(function () {

    });

    $scope.GetCustomerByCustomerID = function(customerID)
    {
        // Call to Web API
        var url = '/api/Customer/getCustomerByCustomerID';

        $http({

            method: 'GET',
            url: Url
        }).success(function (customerList) {
            $scope.AllCustomer = customerList;
        }).error(function () {

        });
    }
})