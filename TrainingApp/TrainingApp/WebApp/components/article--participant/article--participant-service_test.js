var assert = chai.assert;

describe('Participants Service', function () {

    it('should be defined', function(){
        var $injector = angular.injector(['class-scheduling'])
            , service = $injector.get('participantsService');

        assert.isDefined(service);
    });
});
