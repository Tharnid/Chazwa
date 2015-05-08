//(function () {
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

    // OData Queries #1
    //function productListCtrl(productResource) {
    //    var vm = this;

    //    vm.searchCriteria = "GDN";

    //    productResource.query({$skip:1, $top:3}, function (data) {
    //        vm.products = data;
    //    });
    //}

    // OData Queries #2 filter
    function productListCtrl(productResource) {
        var vm = this;

        vm.searchCriteria = "GDN";

        productResource.query({
            $filter: "contains(ProductCode, 'GDN') and Price ge 5 and Price le 20",
            $orderby: "Price desc"}, // older versions substringOf
            function (data) {
            vm.products = data;
        });
    }

    //function productListCtrl(productResource) {
    //    var vm = this;

    //    vm.searchCriteria = "TBX";

    //    productResource.query({search: vm.searchCriteria}, function (data) {
    //        vm.products = data;
    //    });
    //}

    // Alternative code using variables instead of hard-coded values
    //vm.searchCriteria = "GDN";
    //vm.sortProperty = "Price";
    //vm.sortDirection = "desc";

    //productResource.query({
    //    $filter: "contains(ProductCode, '" + vm.searchCriteria + "')" +
    //        " or contains(ProductName, '" + vm.searchCriteria + "')",
    //    $orderby: vm.sortProperty + " " + vm.sortDirection
    //}, function (data) {
    //    vm.products = data;
    //})

    // key operators
    // eq ne gt ge lt le and or not

    // $filter options
    // startswith endswith contains tolower toupper

    // Check out the rest of the examples here:

    // http://www.odata.org/
}());