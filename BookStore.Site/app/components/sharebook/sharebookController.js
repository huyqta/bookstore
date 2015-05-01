'use strict';

myApp.controller('sharebookController', ['$scope', 'sharebookService', function ($scope, sharebookService) {

    sharebookService.taglist().then(function (taglist) {
        $scope.taglist = taglist.data;
    });
    
    $scope.sharebook = function () {
        var postdata = {
            'BookName': $scope.bookname,
            'BookTitle': $scope.booktitle,
            'BookDescription': $scope.bookdescription,
            'Publisher': $scope.publisher,
            'Artist': $scope.artist,
            'Year': $scope.year,
            'Pages': $scope.pages,
            'Language': $scope.language,
            'EbookSize': $scope.size,
            'EbookFormat': $scope.format,
            'EbookUrl': $scope.ebookurl,
            'ImageUrl': $scope.imageurl
        };
        sharebookService.create(postdata);
    };
}]);

