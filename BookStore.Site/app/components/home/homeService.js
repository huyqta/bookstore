'use strict';

var book_api_get_by_tag = 'http://localhost/BookStore.WebAPI/api/books/CreateBook';
var book_api_get_by_id = 'http://localhost/BookStore.WebAPI/api/books/GetBookById';
var book_api_get_all = 'http://localhost/BookStore.WebAPI/api/books';

myApp.factory('sharebookService', function ($http) {
    return {
        get: function () {
            $http.get(book_api_get_all).then(function (data) {
                console.log(data);
                return data;
            }, function(error){
                console.log(error);
                return [];
            });
            return
        }
    }
});