'use strict';

myApp.factory('searchService', function ($http) {
    return {
        getBookByTag: function (id) {
            var book = $http.get(book_api + '/' + id).then(function (data) {
                return data;
            }, function (error) {
                return [];
            });
            return book
        }
    }
});