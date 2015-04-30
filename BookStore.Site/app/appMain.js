var myApp = angular.module('BookStoreApp', ['ngDialog', 'ngRoute']);

//myApp.config(['ngDialogProvider', function (ngDialogProvider) {
//    ngDialogProvider.setDefaults({
//        className: 'ngdialog-theme-default',
//        plain: false,
//        showClose: true,
//        closeByDocument: true,
//        closeByEscape: true,
//        appendTo: false
//    });
//}]);

myApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/sharebook',
            { templateUrl: './app/components/sharebook/sharebook.html' }).
        when('/home',
            { templateUrl: 'app/components/home/home.html' }).
        otherwise(
            { redirectTo: '/home' })
})