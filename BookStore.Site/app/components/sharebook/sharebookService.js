'use strict';

var myApp = angular.module('BookStore');
var book_api_create = 'http://localhost/BookStore.WebAPI/api/books/CreateBook';
var book_api_get_by_id = 'http://localhost/BookStore.WebAPI/api/books/GetBookById';
var book_api_get_all = 'http://localhost/BookStore.WebAPI/api/books';

myApp.factory('sharebookService', function ($http) {
    return {
        create: function (postdata) {
            $http.post('book_api_create', postdata).then(function (data) {
                console.log(data);
                return data;
            }, function (error) {
                console.log(error);
                return [];
            });
            return 
        }
    }
});