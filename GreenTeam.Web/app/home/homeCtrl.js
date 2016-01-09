(function () {
    "use strict";

    angular
        .module("greenTeam")
        .controller("homeCtrl",                  
                       homeCtrl);

    function homeCtrl() {
        var vm = this;
        vm.title = "Green Team - Home page";
    }
})();
