'use strict';

var myApp = angular.module('BookStore');

myApp.controller('SharebookController', ['scope', 'SharebookServices', function ($scope, $homeServices) {
    $scope.books;
    $scope.tags;
}]);

