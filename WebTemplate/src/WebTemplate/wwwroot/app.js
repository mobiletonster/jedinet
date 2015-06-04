(function () {
    'use strict';

    var app = angular.module('app', [
        // Angular modules 
        'ngRoute'

        // Custom modules 

        // 3rd Party Modules
        
    ]);

    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $location.html5Mode(true);

        $routeProvider.when('/home',
            {templateUrl:'/index.html'}
        )
    }]);
})();



