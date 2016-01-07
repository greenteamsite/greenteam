(function () {
    "use strict";

    angular
        .module("greenTeam")
        .factory("personSvc",
        [
            "$http", "$q",
            personSvc
        ]);

    function personSvc($http, $q) {
        return {
            getPerson: function (urlName) {
                var deferred = $q.defer();
                $http.get('api/person/getPerson', { params: { urlName: urlName }, cache: false })
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
