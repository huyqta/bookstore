describe('searchController', function () {
    var $controller, searchSvc;

	beforeEach(module('BookStoreApp'));

	beforeEach(inject(function (_$controller_, searchService) {
		$controller = _$controller_;
		searchSvc = searchService;
	}));

	describe('Search book', function () {
		var $scope, controller;
		beforeEach(function () {
			$scope = {};
			controller = $controller('searchController', { $scope: $scope });
		});

		it('Should return success when call search book by tag service.', function () {
		    var tag = 'IOS';
		    searchSvc.getBookByTag(tag).then(function (data) {
		        expect(data).toHaveBeenCalled();
		    });
		});

		it('Should return success when call search book by name service.', function () {
		    var name = 'Python';
		    searchSvc.getBookByName(name).then(function (taglist) {
		        expect(taglist).toHaveBeenCalled();
		    });
		});
	});
});