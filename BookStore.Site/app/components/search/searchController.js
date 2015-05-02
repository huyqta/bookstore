'use strict';

myApp.controller('searchController', ['$scope', '$routeParams', 'searchService', function ($scope, routeParams, searchService) {
    //$scope.rd.tag = true;
    $scope.searchBook = function () {
        alert($scope.search.value + '-' + $scope.rdtag);
    };

    var value = routeParams.value;

    searchService.getBookByTag(value).then(function (book) {
        $scope.book = book.data;
    });

    searchService.getBookByName(value).then(function (book) {
        $scope.book = book.data;
    });
}]);