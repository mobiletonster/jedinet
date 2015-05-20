/* Declare app module that has dependency on ngResource */
angular.module('class-scheduling', ['ngResource', 'ngRoute', 'ngSanitize', 'angularMoment'])
    .config(['$routeProvider', '$locationProvider', function($routeProvider, $location){
        'use strict';

        $location.html5Mode(true);
        //setup URL routes
        $routeProvider.when('/trainings', {
        	templateUrl: 'components/article--training/article--training-template.html',
        	controller: 'articleTrainingController'
        });
        $routeProvider.when('/participants', {
        	templateUrl: 'components/article--participant/article--participant-template.html',
        	controller: 'articleParticipantController'
        });
        // TODO add a routeProvider for /rooms
        $routeProvider.when('/rooms', {
            templateUrl: 'components/article--room/article--room-template.html',
            controller: 'roomController'
        });

        $routeProvider.otherwise({redirectTo: '/trainings'});
    }]);
