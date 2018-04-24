console.log("app loaded")


angular
    .module("main", [])
    .controller("searchController", ["$scope", "$http", ($scope, $http) => {
           $scope.welcomeMessage = "Welcome to the Library!"
    }])