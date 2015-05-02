'use strict';

myApp.factory('detailService', function ($http) {
    return {
        getBookById: function (id) {
            var book = $http.get(book_api + '/' + id).then(function (data) {
                return data;
            }, function (error) {
                return [];
            });
            return book
        }
    }
});