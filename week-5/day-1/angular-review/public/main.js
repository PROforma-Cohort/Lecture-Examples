const app = angular.module("main", []);


app.controller("mainController", ["$scope", ($scope) => {

  $scope.title = "Hello world!!!"
}])