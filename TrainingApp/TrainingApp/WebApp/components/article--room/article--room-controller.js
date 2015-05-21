angular.module('class-scheduling').controller('roomController', ['$scope', '$q', 'articleRoomService', 'trainingService', function ($scope, $q, articleRoomService, trainingService) {
    'use strict';
    $q.all([articleRoomService.query().$promise, trainingService.query().$promise]).then(function (lists) {
        var rooms     = lists[0],
            trainings = lists[1];
        console.log(lists);
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