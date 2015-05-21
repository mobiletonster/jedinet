var assert = chai.assert;

describe('article--room Service', function () {

    it('should be defined', function(){
        var $injector = angular.injector(['class-scheduling'])
            , service = $injector.get('articleRoomService');

        assert.isDefined(service);
    });
});
