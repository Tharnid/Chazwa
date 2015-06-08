SalesOrderViewModel = function (data) {
    // adding some ko
    var self = this;
    ko.mapping.fromJS(data, {}, self);
}