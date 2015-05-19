angular.module('class-scheduling').controller('articleParticipantController', ['$scope', '$q', 'trainingService', 'participantsService', function($scope, $q, trainingService, participantsService){
    'use strict';

    $q.all([participantsService.query().$promise, trainingService.query().$promise]).then(function (lists) {
    var participants = lists[0],
        trainings = lists[1];

        $scope.participants = participants.map(function (participant) {
            var peep = angular.copy(participant);

            peep.trainings = trainings.filter(function (training) {
                return training.presenters.filter(function (pres) {
                    return pres.id === peep.id;
                }).length;
            });

            return peep;
        }).filter(function(peep) {
            return peep.trainings.length;
        });
    });
}]);
