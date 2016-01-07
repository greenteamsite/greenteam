(function () {
    "use strict";

    angular
        .module("greenTeam")
        .controller("personCtrl",
                    ["personSvc", "projectsSvc", "$routeParams",
                       personCtrl]);

    function personCtrl(personSvc, projectsSvc, $routeParams) {
        var vm = this;
        vm.title = "Green Team - Person page";
        var init = function () {
            personSvc.getPerson($routeParams.urlName).then(function (data) {
                vm.person = data;
            });
            projectsSvc.getProjectsByPerson($routeParams.urlName).then(function (data) {
                vm.projects = data;
            });
        }

        init();
    }
})();
