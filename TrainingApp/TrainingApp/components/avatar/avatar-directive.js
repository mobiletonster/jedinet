angular.module('class-scheduling').directive('avatarImg', function() {
    'use strict';

    return {
      restrict: 'EA',
      scope: {
          'src': '=avatarSrc',
          'alt': '=avatarAlt'
      },
      templateUrl: 'components/avatar/avatar-template.html'
    };
});
