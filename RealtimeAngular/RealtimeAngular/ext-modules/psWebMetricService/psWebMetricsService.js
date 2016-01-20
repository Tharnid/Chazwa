'use strict';

angular.module('psWebMetricsService', []).factory('psWebMetricsService', function () {

    var hub = $.connection.metricHub;

    hub.client.broadcastMessage = function (time, bandwidthPct, cpuPct,
                        salesAmt, alphaSalesAmt, betaSalesAmt) {


    };

    $.connection.hub.start()
        .done()
        .fail(function (data) {
            alert(data);
        }
    );

    return {

    };
})