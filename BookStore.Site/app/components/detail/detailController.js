'use strict';

myApp.controller('detailController', ['$scope', '$routeParams', 'detailService', function ($scope, routeParams, detailService) {
    var id = routeParams.id;
    detailService.getBookById(id).then(function (book) {
        $scope.book = book.data;
    });
}]);