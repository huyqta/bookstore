var myApp = angular.module('BookStoreApp', ['ngRoute']);

// HOST
var host = 'http://localhost/BookStore.WebAPI/';
// restfulapi
var book_api = host + 'api/books';
var tag_api = host + 'api/tags';
// Custom API
var book_api_get_latest_book = host + 'api/books/SelectLastestBook/5';
var book_api_search_by_tag = host + 'api/books/SearchBookByTag';
var book_api_search_by_name = host + 'api/books/SearchBookByName';
var book_api_select_by_page = host + 'api/books/SelectBookOfPage';

myApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/sharebook',
            { templateUrl: './app/components/sharebook/sharebook.html' }).
        when('/home',
            { templateUrl: './app/components/home/home.html' }).
        when('/home/:value',
            { templateUrl: './app/components/home/home.html' }).
        when('/detail/:id',
            { templateUrl: './app/components/detail/detail.html' }).
        when('/search/:type/:value',
            { templateUrl: './app/components/search/search.html' }).
        otherwise(
            { redirectTo: '/home' })
})