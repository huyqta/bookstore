describe('homeController', function () {
    var $controller, homeSvc;

    beforeEach(module('BookStoreApp'));

    beforeEach(inject(function (_$controller_, homeService) {
        $controller = _$controller_;
        homeSvc = homeService;
    }));

    var $scope, controller;
    beforeEach(function () {
        $scope = {};
        controller = $controller('homeController', { $scope: $scope });
    });

    describe('Get Latest Books', function () {
        it('Should return success when call get latest book service.', function () {
            homeSvc.getLatestBook().then(function (latestBook) {
                expect(latestBook).toHaveBeenCalled();
            });
        });

        it('Should return success when call get all book service.', function () {
            homeSvc.getBookByPage(0).then(function (books) {
                expect(books).toHaveBeenCalled();
            });
        });
    });
});