﻿angularFormsApp.factory('DataService',
    ["$http",
    function ($http) {

        var getEmployees = function () {

            return $http.get("Employee/GetEmployees");
        };

                var getEmployee = function (id) {
                    if (id == 123) {
                        return {
                            id: 123,
                            fullName: "Milton Waddams",
                            notes: "The ideal employee.  Just don't touch his red stapler.",
                            department: "Administration",
                            dateHired: "July 11 2014",
                            breakTime: "July 11 2014 3:00 PM",
                            email: "mwaddams@initech.com",
                            url: "http://wwww.blah.com",
                            perkCar: true,
                            perkStock: false,
                            perkSixWeeks: true,
                            payrollType: "none"
                        };
                    }
                    return undefined;
                };

        var insertEmployee = function (newEmployee) {
            return true;
        };

        var updateEmployee = function (employee) {
            return true;
        };

        return {
            insertEmployee: insertEmployee,
            updateEmployee: updateEmployee,
            getEmployee: getEmployee,
            getEmployees: getEmployees
        };
    }]);

//angularFormsApp.factory('DataService',
//    function () {

//        var getEmployees = function () {
//            $http.get("Employees/GetEmployess");
//        };

//        var getEmployee = function (id) {
//            if (id == 123) {
//                return {
//                    id: 123,
//                    fullName: "Milton Waddams",
//                    notes: "The ideal employee.  Just don't touch his red stapler.",
//                    department: "Administration",
//                    dateHired: "July 11 2014",
//                    breakTime: "July 11 2014 3:00 PM",
//                    email: "mwaddams@initech.com",
//                    url: "http://wwww.blah.com",
//                    perkCar: true,
//                    perkStock: false,
//                    perkSixWeeks: true,
//                    payrollType: "none"
//                };
//            }
//            return undefined;
//        };

//        var insertEmployee = function (newEmployee) {
//            return true;
//        };

//        var updateEmployee = function (employee) {
//            return true;
//        };

//        return {
//            insertEmployee: insertEmployee,
//            updateEmployee: updateEmployee,
//            getEmployee: getEmployee
//        };
//    });