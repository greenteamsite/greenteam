(function () {
    "use strict";

    angular
        .module("greenTeam")
        .controller("aboutCtrl",
                    ["aboutSvc",
                       aboutCtrl]);

    function aboutCtrl(aboutSvc) {
        var vm = this;
        vm.title = "Green Team - About page";
    }
})();
