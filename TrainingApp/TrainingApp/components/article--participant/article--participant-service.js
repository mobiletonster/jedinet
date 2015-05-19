angular.module('class-scheduling').factory('participantsService', ['$resource', function($resource) {
    'use strict';
    return $resource('/api/participants');
}]);
