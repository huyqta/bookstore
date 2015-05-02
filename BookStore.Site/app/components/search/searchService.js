'use strict';

myApp.factory('searchService', function ($http) {
    return {
        getBookByTag: function (value) {
            var book = $http.get(book_api_search_by_tag + '/' + value).then(function (data) {
                return data;
            }, function (error) {
                return [];
            });
            return book
        },
        getBookByName: function (value) {
            var book = $http.get(book_api_search_by_name + '/' + value).then(function (data) {
            return data;
        }, function (error) {
            return [];
        });
        return book
    }
    }
});