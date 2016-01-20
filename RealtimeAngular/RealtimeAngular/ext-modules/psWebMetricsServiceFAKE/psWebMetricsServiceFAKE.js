'use strict';

angular.module('psWebMetricsServiceFAKE', []).factory('psWebMetricsService', function () {

    var bandwidthPct = 20.0;
    var cpuPct = 10.0;
    var salesAmt = 1000.0;
    var alphaSalesAmt = 700.0;
    var betaSalesAmt = 300.0;

    var broadcastMessage = function (time, bandwidthPct, cpuPct,
                                     salesAmt, alphaSalesAmt, betaSalesAmt) {


    };

    setInterval(function () {

        broadcastMessage(new Date(), bandwidthPct, cpuPct,
            salesAmt, alphaSalesAmt, betaSalesAmt);

        // update values
        var r = Math.random();
        bandwidthPct += 15 * r - 7.5;
        if (bandwidthPct > 100) bandwidthPct = 100;
        if (bandwidthPct < 0) bandwidthPct = 0;

        r = Math.random();
        cpuPct += 15 * r - 7.5;
        if (cpuPct > 100) cpuPct = 100;
        if (cpuPct < 0) cpuPct = 0;

        r = Math.random();
        alphaSalesAmt += r * 10;
        if (alphaSalesAmt < 0) alphaSalesAmt = 0;

        r = Math.random();
        betaSalesAmt += r * 10;
        if (betaSalesAmt < 0) betaSalesAmt = 0;

        salesAmt = alphaSalesAmt + betaSalesAmt;

    }, 100);

    return {

    };
});