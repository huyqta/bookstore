'use strict';

myApp.factory('sharebookService', function ($http) {
    return {
        create: function (book) {
            var transform = function (data) {
                return $.param(data);
            }
            var book = $http.post(book_api, book, {
                headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' },
                transformRequest: transform
            }).then(function (data) {
                return data;
            }, function (error) {
                return []
            });
            return book;
        },
        taglist: function () {
            var taglist = $http.get(tag_api).then(function (data) {
                return data;
            });
            return taglist;
        }
    }
});