'use strict';

myApp.controller('searchController', ['$scope', '$routeParams', '$location', 'searchService', function ($scope, $routeParams, $location, searchService) {

    $scope.searchtext = 'Searching book...';

    $scope.stype = {
        type: "stag"
    };

    //$scope.books = function () {
    var type = $routeParams.type;
    var value = $routeParams.value;
    switch (type) {
        case 'stag':
            searchService.getBookByTag(value).then(function (book) {
                $scope.books = book.data;
                $scope.searchtext = 'Have ' + $scope.books.length + ' book(s) found.';
            });
            break;
        case 'sname':
            searchService.getBookByName(value).then(function (book) {
                $scope.books = book.data;
                $scope.searchtext = 'Have ' + $scope.books.length + ' book(s) found.';
            });
            break;
    }
    //};


    $scope.searchBook = function () {
        var urlSearch = "/search/" + $scope.stype.type + "/" + $scope.searchvalue;
        $location.path(urlSearch);
    };
}]);