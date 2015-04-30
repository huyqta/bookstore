'use strict';

var myApp = angular.module('BookStoreApp');

myApp.controller('sharebookController', ['$scope', 'sharebookService', function ($scope, sharebookService) {

    $http.defaults.headers.post["Content-Type"] = "application/x-www-form-urlencoded";

    $scope.sharebook = function () {
        var postdata = {
            BookName: $scope.bookname,
            BookTitle: $scope.booktitle,
            BookDescription: $scope.bookdescription,
            Publisher: $scope.publisher,
            Artist: $scope.artist,
            Year: $scope.year,
            Pages: $scope.pages,
            Language: $scope.language,
            EbookSize: $scope.size,
            EbookFormat: $scope.format,
            EbookUrl: $scope.ebookurl,
            ImageUrl: $scope.imageurl
        };
        sharebookService.create(postdata);
    };
}]);

