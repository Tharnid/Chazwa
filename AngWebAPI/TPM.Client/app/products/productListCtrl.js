﻿//(function () {
//    "use strict";
//    angular
//        .module("productManagement")
//        .controller("ProductListCtrl",
//                     ["productResource",
//                         ProductListCtrl]);

//    function ProductListCtrl(productResource) {
//        var vm = this;

//        vm.searchCriteria = "GDN";

//        productResource.query({ search: vm.searchCriteria }, function (data) {
//            vm.products = data;
//        });
//    }
//}());

(function () {
    "use strict";
    angular
        .module("productManagement")
        .controller("productListCtrl",
                     ["productResource",
                         productListCtrl]);

    //function productListCtrl(productResource) {
    //    var vm = this;

    //    productResource.query(function (data) {
    //        vm.products = data;
    //    });
    //}

    function productListCtrl(productResource) {
        var vm = this;

        vm.searchCriteria = "TBX";

        productResource.query({search: vm.searchCriteria}, function (data) {
            vm.products = data;
        });
    }

}());