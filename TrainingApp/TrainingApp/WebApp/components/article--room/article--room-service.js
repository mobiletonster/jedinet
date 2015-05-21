/* user service */
angular.module('class-scheduling').factory('articleRoomService', ['$resource', function($resource){
    'use strict';

    return $resource('/api/rooms');
    //EXAMPLE Return below
    // return $resource('user/:id', {id: '@id'}, {
        //Angular does a POST by default for create and update
        //this adds an $update method that will do a PUT
        // update: {method: 'PUT'}
    // });
}]);
