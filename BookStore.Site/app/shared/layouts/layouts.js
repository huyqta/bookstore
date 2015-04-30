myApp.directive('bsheader', function () {
    return {
        restrict: 'E',
        templateUrl: 'app/shared/layouts/header.html'
    };
});

myApp.directive('bsfooter', function () {
    return {
        restrict: 'E',
        templateUrl: 'app/shared/layouts/footer.html'
    };
});

myApp.directive('scdbsfooter', function () {
    return {
        restrict: 'E',
        templateUrl: 'app/shared/layouts/footer.html'
    };
});

//myApp.directive('modalDialog', function () {
//    return {
//        restrict: 'E',
//        scope: {
//            show: '='
//        },
//        replace: true,
//        transclude: true,
//        link: function (scope, element, attrs) {
//            scope.dialogStyle = {};
//            if (attrs.width) {
//                scope.dialogStyle.width = attrs.width;
//            }
//            if (attrs.height) {
//                scope.dialogStyle.height = attrs.height;
//            }
//            scope.hideModal = function () {
//                scope.show = false;
//            };
//        },
//        templateUrl: 'app/components/sharebook/sharebook.html'
//    };
//});