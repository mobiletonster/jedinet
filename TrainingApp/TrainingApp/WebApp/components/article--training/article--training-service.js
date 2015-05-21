angular.module('class-scheduling').factory('trainingService', ['$resource', function($resource){
    'use strict';
    return $resource('/api/trainings');
}]);
