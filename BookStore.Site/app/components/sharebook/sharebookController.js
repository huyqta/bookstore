'use strict';

var myApp = angular.module('BookStoreApp');

myApp.controller('sharebookController', ['$scope', function ($scope) {
    $scope.books;
    $scope.tags;
    $scope.modalShow = false;
    $scope.toggleModal = function () {
        $scope.modalShow = !$scope.modalShow;
    };
}]);

