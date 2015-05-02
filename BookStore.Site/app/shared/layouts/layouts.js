myApp.directive('bsheader', function () {
    return {
        restrict: 'E',
        controller: 'searchController',
        templateUrl: 'app/shared/layouts/header.html'
    };
});

myApp.directive('bsfooter', function () {
    return {
        restrict: 'E',
        templateUrl: 'app/shared/layouts/footer.html'
    };
});

myApp.directive('waiting', function () {
    return {
        restrict: 'E',
        templateUrl: 'app/shared/layouts/waiting.html'
    };
});


myApp.directive('ngEnter', function () {
    return function (scope, element, attrs) {
        element.bind("keydown keypress", function (event) {
            if (event.which === 13) {
                scope.$apply(function () {
                    scope.$eval(attrs.ngEnter);
                });
                event.preventDefault();
            }
        });
    };
});