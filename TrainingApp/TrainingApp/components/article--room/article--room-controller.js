angular.module('class-scheduling').controller('roomController', ['$scope', '$q', 'roomService', 'trainingService', function($scope, $q, roomService, trainingService) {
    'use strict';
    $q.all([roomService.query().$promise, trainingService.query().$promise]).then(function (lists) {
        var rooms     = lists[0],
            trainings = lists[1];
        $scope.rooms = rooms.map(function (room) {
            var rm = angular.copy(room);
            rm.trainings = trainings.filter(function (training) {
                return training.room.id === rm.id;
            });
            return rm;
        }).filter(function(room) {
            return room.trainings.length;
        });
    });
}]);