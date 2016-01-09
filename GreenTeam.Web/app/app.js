(function () {
    "use strict";

    var app = angular.module("greenTeam",
    ["ngRoute", "ngTouch", "ngSanitize", "ngAnimate"]);
    app.config([
        '$routeProvider', '$locationProvider',
        function ($routeProvider, $locationProvider) {
            $locationProvider.html5Mode(true);

            $routeProvider
                .when("/", { templateUrl: "app/home/home.html" })
                .when('/about', {
                    templateUrl: 'app/about/about.html'
                })
                .when('/contacts', {
                    templateUrl: 'app/contacts/contacts.html'
                })
                .when('/projects', {
                    templateUrl: 'app/projects/projects.html'
                })
                .when('/person/:urlName', {
                    templateUrl: 'app/person/person.html'
                })
                .otherwise({
                    redirectTo: '/'
                });
        }
    ]);

}());