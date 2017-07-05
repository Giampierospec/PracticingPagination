(function () {
    var app = angular.module("books", ["ui.bootstrap"]);
    app.controller('BooksController', function ($scope, $http) {
        var books = [];
        $scope.filteredData = [];
        $scope.data = [];
        $scope.currentPage = 1;
        $scope.numPerPage = 10;
        $scope.maxSixe = 5;
        $http.get("/Books/Index")
              .then(function (response) {
                   books = angular.fromJson(response.data);
                   $scope.data = books;
                   $scope.$watch('currentPage + numPerPage', function () {
                       var begin = (($scope.currentPage - 1) * $scope.numPerPage);
                       var end = begin + $scope.numPerPage;
                       $scope.filteredData = books.slice(begin, end);
                       console.log(books);
                   });
              }, function (err) {
                  console.log(err);
              });
        
    })
})();