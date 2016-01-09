(function () {
    "use strict";

    angular
        .module("greenTeam")
        .factory("aboutSvc",
        [
            "$http", "$q",
            aboutSvc
        ]);

    function aboutSvc($http, $q) {
        return {
            getAboutInfo: function () {
                var deferred = $q.defer();
                $http.get('api/about/getAboutInfo', { cache: true })
                    .success(function (data) {
                        deferred.resolve(data);
                    })
                    .error(function (error) {
                        deferred.reject(error);
                    });
                return deferred.promise;
            }
        }
    }
})();
