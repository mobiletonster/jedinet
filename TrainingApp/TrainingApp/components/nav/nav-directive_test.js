// var assert = chai.assert;

// describe('nav directive tests', function () {

//   beforeEach(module('class-scheduling'));

//   beforeEach(inject(function(_$compile_, _$rootScope_){
//       // The injector unwraps the underscores (_) from around the parameter names when matching
//       $compile = _$compile_;
//       $rootScope = _$rootScope_;
//   }));

//   it('Replaces the element with the appropriate content', function() {
//       // Compile a piece of HTML containing the directive
//       var element = $compile("<nav-directive></navi-directive>")($rootScope);
//       // fire all the watches, so the scope expression {{1 + 1}} will be evaluated
//       $rootScope.$digest();
//       // Check that the compiled element contains the templated content
//       assert.include(element.html(), "I am naviDirective", 'Does not contain the stuff');
//   });
// });
