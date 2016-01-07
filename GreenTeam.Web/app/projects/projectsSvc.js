(function () {
    "use strict";

    angular
        .module("greenTeam")
        .factory("projectsSvc",
        [
            "$http", "$q",
            projectsSvc
        ]);

    function projectsSvc($http, $q) {
        return {
            getProjects: function (urlName) {
                var deferred = $q.defer();
                $http.get('api/project/getProjects', { cache: false })
                    .success(function (data) {
                        deferred.resolve(data);
                    })
                    .error(function (error) {
                        deferred.reject(error);
                    });
                return deferred.promise;
            },
            getProjectsByPerson: function (urlName) {
                var deferred = $q.defer();
                $http.get('api/project/getProjectsByPerson', { params: { urlName: urlName }, cache: true })
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
