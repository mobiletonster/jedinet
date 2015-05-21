angular.module('class-scheduling').controller('articleTrainingController', ['$scope', 'trainingService', function($scope, trainingService){
    'use strict';

    trainingService.query(function (collection) {
        $scope.trainings = collection;
    });
}]);
