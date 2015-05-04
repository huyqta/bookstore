'use strict';

myApp.controller('homeController', ['$scope', '$routeParams', 'homeService', function ($scope, routeParams, homeService) {

    //var value = routeParams.value;
    //if (value === undefined || value < 0) value = 0;

    $scope.page = 0;

    homeService.getLatestBook().then(function (latestBook) {
        $scope.latestBook = latestBook.data;
    });

    //homeService.getBookByPage(value).then(function (books) {
    //    $scope.bookByPage = books.data;
    //    $scope.showPrev = function () {
    //        if (value === undefined || value === '0')
    //            return false;
    //        else
    //            return true;
    //    }

    //    $scope.showNext = function () {
    //        if ($scope.bookByPage.length < 5)
    //            return false;
    //        else
    //            return true;
    //    }
    //});

    $scope.getBookByPage = function (value) {
        homeService.getBookByPage(value).then(function (books) {

            $scope.page = value;

            $scope.pageprev = value - 1;
            $scope.pagenext = value + 1;
            
            $scope.bookByPage = books.data;
            $scope.showPrev = function () {
                if ($scope.pageprev === undefined || $scope.pageprev < 0)
                    return false;
                else
                    return true;
            }

            $scope.showNext = function () {
                if ($scope.bookByPage.length < 5)
                    return false;
                else
                    return true;
            }
        });
    }

    $scope.getBookByPage(0);
}]);