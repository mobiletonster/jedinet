var assert = chai.assert;

describe('Article Participant Controller', function () {
    beforeEach(module('class-scheduling'));

    it('should be defined', inject(function($rootScope, $controller){
        var scope = $rootScope.$new()
            , ctrl = $controller('articleParticipantController', {$scope: scope});


        assert.isDefined(ctrl);
    }));

    it('should have a stubb that is true', inject(function($rootScope, $controller){
        var scope = $rootScope.$new()
            , ctrl = $controller('articleParticipantController', {$scope: scope});


        //assert.isDefined(scope.stubb);
        //assert.strictEqual(scope.stubb, true);
    }));
});
