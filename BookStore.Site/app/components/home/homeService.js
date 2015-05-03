'use strict';

myApp.factory('homeService', function ($http) {
    return {
        getBookByPage: function (value) {
            if (value === undefined || value < 0) value = 0;
            var allBook = $http.get(book_api_select_by_page + "/" + value).then(function (data) {
                return data;
            }, function (error) {
                return [];
            });
            return allBook;
        },

        getLatestBook: function () {
            var latestBook = $http.get(book_api_get_latest_book).then(function (data) {
                return data;
            }, function (error) {
                return [];
            });
            return latestBook;
        }
    }
});