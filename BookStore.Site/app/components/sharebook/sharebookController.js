'use strict';

myApp.controller('sharebookController', ['$scope', '$location', 'sharebookService', function ($scope, $location, sharebookService) {
    $scope.btnshare = "Share book!";
    $scope.disablebtn = form.$invalid;
    $scope.tags = [];

    sharebookService.taglist().then(function (taglist) {
        $scope.taglist = taglist.data;
    });
    


    $scope.sharebook = function () {
        $scope.btnshare = "Sharing...";
        $scope.disablebtn = true;
        var tagsString = $scope.tags.join('|');
        var postdata = {
            BookName: $scope.bookname,
            BookTitle: $scope.booktitle,
            BookDescription: $scope.bookdescription,
            Publisher: $scope.publisher,
            Artist: $scope.artist,
            Year: $scope.year,
            Pages: $scope.pages,
            Language: $scope.language,
            EbookSize: $scope.size,
            EbookFormat: $scope.format,
            EbookUrl: $scope.ebookurl,
            ImageUrl: $scope.imageurl,
            Tags: tagsString
        };
        sharebookService.create(postdata).then(function (data) {
            if (data != []) {
                var urlDetail = "/detail/" + data.data.Id;
                $location.path(urlDetail);
            }
        });
    };

    $scope.checkTag = function (isChecked, tagId) {        
        if (isChecked === true) {
            $scope.tags.push(tagId);
        }
        else {
            var indexTag = $scope.tags.indexOf(tagId);
            if (indexTag > -1) {
                $scope.tags.splice(indexTag, 1);
            }
        }
        console.log($scope.tags);
    };
}]);

