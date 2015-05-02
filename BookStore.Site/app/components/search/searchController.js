'use strict';

myApp.controller('searchController', ['$scope', '$routeParams', '$location', 'searchService', function ($scope, $routeParams, $location, searchService) {
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
            });
            break;
        case 'sname':
            searchService.getBookByName(value).then(function (book) {
                $scope.books = book.data;
            });
            break;
    }
    //};


    $scope.searchBook = function () {
        var urlSearch = "/search/" + $scope.stype.type + "/" + $scope.searchvalue;
        $location.path(urlSearch);
    };
}]);