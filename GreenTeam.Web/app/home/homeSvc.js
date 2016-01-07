(function () {
    "use strict";

    angular
        .module("greenTeam")
        .factory("homeSvc",
        [
            "$http", "$q",
            homeSvc
        ]);

    function homeSvc($http, $q) {
        var deferred = $q.defer();
        return {
            getHomeInfo: function() {
                $http.get('api/home/getHomeInfo', { cache: true })
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
}
());
