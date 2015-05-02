var myApp = angular.module('BookStoreApp', ['ngDialog', 'ngRoute']);

var book_api = 'http://localhost/BookStore.WebAPI/api/books';
var tag_api = 'http://localhost/BookStore.WebAPI/api/tags';
// Custom API
var book_api_get_latest_book = 'http://localhost/BookStore.WebAPI/api/books/SelectLastestBook/6';

myApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/sharebook',
            { templateUrl: './app/components/sharebook/sharebook.html' }).
        when('/home',
            { templateUrl: './app/components/home/home.html' }).
        when('/detail/:id',
            { templateUrl: './app/components/detail/detail.html' }).
        otherwise(
            { redirectTo: '/home' })
})