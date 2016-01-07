(function () {
    "use strict";

    angular
        .module("greenTeam")
        .controller("projectsCtrl",
                    ["projectsSvc",
                       projectsCtrl]);

    function projectsCtrl(projectsSvc) {
        var vm = this;
        vm.title = "Green Team - Projects page";
        var init = function () {
            projectsSvc.getProjects().then(function (data) {
                vm.projects = data;
            });
        }

        init();
    }
})();
