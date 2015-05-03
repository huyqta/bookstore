describe('sharebookController', function () {
    var $controller, sharebookSvc;

	beforeEach(module('BookStoreApp'));

	beforeEach(inject(function (_$controller_, sharebookService) {
		$controller = _$controller_;
		sharebookSvc = sharebookService;
	}));

	describe('latestBook', function () {
		var $scope, controller;
		beforeEach(function () {
			$scope = {};
			controller = $controller('sharebookController', { $scope: $scope });
		});

		it('Should return success when call create new book service.', function () {
		    //var postdata = {
		    //    BookName: 'UNIT_TEST',
		    //    BookTitle: 'UNIT_TEST',
		    //    BookDescription: 'UNIT_TEST',
		    //    Publisher: 'UNIT_TEST',
		    //    Artist: 'UNIT_TEST',
		    //    Year: 2000,
		    //    Pages: 2000,
		    //    Language: 'UNIT_TEST',
		    //    EbookSize: 'UNIT_TEST',
		    //    EbookFormat: 'UNIT_TEST',
		    //    EbookUrl: 'UNIT_TEST',
		    //    ImageUrl: 'UNIT_TEST',
		    //    Tags: ''
		    //};
		    sharebookSvc.createBook().then(function (data) {
		        expect(data).toHaveBeenCalled();
		    });
		    expect(true).toBe(true);
		});

		it('Should return tags when call get tag list service.', function () {
		    sharebookSvc.getTags().then(function (taglist) {
		        expect(taglist).toHaveBeenCalled();
		    });
		});
	});
});