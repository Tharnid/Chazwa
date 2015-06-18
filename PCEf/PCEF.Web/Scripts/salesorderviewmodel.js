// ObjectState
//var ObjectState = {
//    Unchanged: 0,
//    Added: 1,
//    Modified: 2,
//    Deleted: 3
//};

//SalesOrderViewModel = function (data) {
//    // adding some ko
//    var self = this;
//    ko.mapping.fromJS(data, {}, self);

//    // save 
//    self.save = function () {
//        // JQuery Ajax function handles the heavy lifting
//        self.save = function () {
//            $.ajax({
//                url: "/Sales/Save/",
//                type: "POST",
//                data: ko.toJSON(self), // self references viewmodel
//                contentType: "application/json",
//                success: function (data) {
//                    if (data.salesOrderViewModel != null) // only if present
//                        ko.mapping.fromJS(data.salesOrderViewModel, {}, self); // handles whatever comes back
//                }
//            });
//        },

//        self.flagSalesOrderAsEdited = function () {
//            alert("flagged!!!");
//            if (self.ObjectState() != ObjectState.Added) {
//                self.ObjectState(ObjectState.Modified);
//            }

//            return true;
//        };
//    }
//};

var ObjectState = {
    Unchanged: 0,
    Added: 1,
    Modified: 2,
    Deleted: 3
};


SalesOrderViewModel = function (data) {
    var self = this;
    ko.mapping.fromJS(data, {}, self);

    self.save = function () {
        $.ajax({
            url: "/Sales/Save/",
            type: "POST",
            data: ko.toJSON(self),
            contentType: "application/json",
            success: function (data) {
                if (data.salesOrderViewModel != null)
                    ko.mapping.fromJS(data.salesOrderViewModel, {}, self);

                if (data.newLocation != null)
                    window.location = data.newLocation;
            }
        });
    },

    self.flagSalesOrderAsEdited = function () {
        if (self.ObjectState() != ObjectState.Added) {
            self.ObjectState(ObjectState.Modified);
        }

        return true;
    };
};