var assert = chai.assert;

describe('Training Service', function () {

    it('should be defined', function(){
        var $injector = angular.injector(['class-scheduling'])
            , service = $injector.get('trainingService');

        assert.isDefined(service);
    });
});
