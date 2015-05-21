angular.module('class-scheduling').directive('editToggler', function() {
    'use strict';
    return {
        restrict: 'EA',
        link: function (scope, el) {
            var elem = el[0];
            elem.querySelector('.article__edit-toggle-checkbox').addEventListener('change', function (e) {
                var isEditable = e.target.checked;
                el.toggleClass('edit-mode');
                [].slice.call(elem.querySelectorAll('[ng-model]')).forEach(function (e) {
                    if (isEditable) {
                        e.contentEditable = true;
                    } else {
                        e.contentEditable = false;
                    }
                });
            });
        }
    };
});
