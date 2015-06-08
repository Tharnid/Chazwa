SalesOrderViewModel = function (data) {
    // adding some ko
    var self = this;
    ko.mapping.fromJS(data, {}, self);

    // save 
    self.save = function () {
        // JQuery Ajax function handles the heavy lifting
        self.save = function () {
            $.ajax({
                url: "/Sales/Save/",
                type: "POST",
                data: ko.toJSON(self), // self references viewmodel
                contentType: "application/json",
                success: function (data) {
                    if (data.salesOrderViewModel != null) // only if present
                        ko.mapping.fromJS(data.salesOrderViewModel, {}, self); // handles whatever comes back
                }
            });
        }
    }
}