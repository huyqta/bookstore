'use strict';

myApp.controller('searchController', ['$scope', '$routeParams', 'searchService', function ($scope, routeParams, searchService) {
    var id = routeParams.id;
    searchService.getBookByTag(id).then(function (book) {
        $scope.book = book.data;
    });
}]);