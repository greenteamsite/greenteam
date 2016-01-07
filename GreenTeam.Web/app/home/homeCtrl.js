(function () {
    "use strict";

    angular
        .module("greenTeam")
        .controller("homeCtrl",
                    [ "homeSvc",
                       homeCtrl]);

    function homeCtrl(homeSvc) {
        var vm = this;
        homeSvc.getHomeInfo().then(function (data) {
            vm.data = data;
        });
        vm.title = "Green Team - Home page";

    }
})();
