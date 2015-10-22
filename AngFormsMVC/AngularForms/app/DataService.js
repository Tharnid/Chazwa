
angularFormsApp.factory('DataService',
    function () {
        return {
            employee: {
                fullName: "Han Solo",
                notes: "Scruffy nerf herder",
                department: "Procurement",
                perkCar: true,
                perkStock: false,
                perkSixWeeks: true,
                payrollType: "none"
            }
        }
    });