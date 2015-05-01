var myApp = angular.module('BookStoreApp', ['ngDialog', 'ngRoute']);

var book_api = 'http://localhost/BookStore.WebAPI/api/books';
var tag_api = 'http://localhost/BookStore.WebAPI/api/tags';

myApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/sharebook',
            { templateUrl: './app/components/sharebook/sharebook.html' }).
        when('/home',
            { templateUrl: 'app/components/home/home.html' }).
        otherwise(
            { redirectTo: '/home' })
})