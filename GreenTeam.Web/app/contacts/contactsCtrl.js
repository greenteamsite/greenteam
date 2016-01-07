(function () {
    "use strict";

    angular
        .module("greenTeam")
        .controller("contactsCtrl", contactsCtrl);

    function contactsCtrl() {
        var vm = this;
        vm.title = "Green Team - Contacts page";
    }
})();
