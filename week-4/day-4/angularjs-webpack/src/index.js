const app = angular.module("main", ["customFilters"]);

app.controller("mainController", ($scope) => {
    $scope.title = "Hello World!"
})