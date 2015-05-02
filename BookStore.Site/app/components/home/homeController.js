'use strict';

myApp.controller('homeController', ['$scope', 'homeService', function ($scope, homeService) {
    homeService.getLatestBook().then(function (latestBook) {
        $scope.latestBook = latestBook.data;
    });
}]);