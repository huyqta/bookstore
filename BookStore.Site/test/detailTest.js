describe('detailController', function () {
    var $controller, detailSvc;

	beforeEach(module('BookStoreApp'));

	beforeEach(inject(function (_$controller_, detailService) {
		$controller = _$controller_;
		detailSvc = detailService;
	}));

	describe('Search book', function () {
		var $scope, controller;
		beforeEach(function () {
			$scope = {};
			controller = $controller('detailController', { $scope: $scope });
		});

		it('Should return success when call detail book by id service.', function () {
		    var id = '00000000-0000-0000-0000-000000000000';
		    detailSvc.getBookById(id).then(function (data) {
		        expect(data).toHaveBeenCalled();
		    });
		});
	});
});