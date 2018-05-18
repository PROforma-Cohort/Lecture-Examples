var app = angular.
    module("main", ["ngRoute"])

app.config(function ($routeProvider) {
    $routeProvider.when("/home", {
        templateUrl: '/scripts/app/pages/menu.html',
        controller: 'homeController'
    })

    $routeProvider.otherwise({ redirectTo: "/home" });
})

app.controller("homeController", ["$scope", "$http", function ($scope, $http) {
    $scope.test = "hello";
}]);