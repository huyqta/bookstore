describe('sharebookController', function () {
    var $controller, sharebookSvc;

	beforeEach(module('BookStoreApp'));

	beforeEach(inject(function (_$controller_, sharebookService) {
		$controller = _$controller_;
		sharebookSvc = sharebookService;
	}));

	describe('Share book', function () {
		var $scope, controller;
		beforeEach(function () {
			$scope = {};
			controller = $controller('sharebookController', { $scope: $scope });
		});

		it('Should return success when call create new book service.', function () {
		    sharebookSvc.createBook().then(function (data) {
		        expect(data).toHaveBeenCalled();
		    });
		});

		it('Should return tags when call get tag list service.', function () {
		    sharebookSvc.getTags().then(function (taglist) {
		        expect(taglist).toHaveBeenCalled();
		    });
		});
	});
});