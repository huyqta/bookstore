'use strict';

myApp.factory('homeService', function ($http) {
    return {
        get: function () {
            $http.get(book_api).then(function (data) {
                return data;
            }, function(error){
                return [];
            });
            return
        },
        
        getLatestBook: function () {
            var latestBook = $http.get(book_api_get_latest_book).then(function (data) {
                return data;
            })
            return latestBook;
        }
    }
});