var assert = chai.assert;

describe('articleRoom filter tests', function () {
  beforeEach(module('class-scheduling'));

  it('should be defined', inject(function ($filter) {
      var filter = $filter('articleRoomFilter');

      assert.isDefined(filter);
  }));
});
