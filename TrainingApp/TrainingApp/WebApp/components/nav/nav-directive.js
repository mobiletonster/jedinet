angular.module('class-scheduling').directive('navDirective', function() {
  'use strict';

  return {
    restrict: 'E',
    templateUrl: 'components/nav/nav-template.html',
    link: function(){
      var links = [].slice.call(document.querySelectorAll('.nav__item'));

      links.forEach(function (link) {
          link.addEventListener('click', function (e) {
            // e.target;
          });
      });
    }
  };
});
