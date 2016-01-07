(function () {
    "use strict";

    angular
        .module("greenTeam")
        .factory("aboutSvc",
        [
            "$http",
            aboutSvc
        ]);

    function aboutSvc($http) {
        return {
            getAboutInfo: function () {
                $http.get('/home/getAboutInfo', { cache: true })
                    .then(function (data) {
                        return data;
                    }, function (error) {
                        return error;
                    })
            }
        }
    }
})();
