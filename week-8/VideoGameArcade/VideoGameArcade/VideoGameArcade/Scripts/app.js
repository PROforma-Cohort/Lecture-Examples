console.log("app loaded");

const app = angular.module("main", ["ngRoute"]);



// mysite.com/games
// mysite.com/#!/games

app.config(function ($routeProvider) {

    $routeProvider.when("/games", {
        templateUrl: "/Scripts/app/views/games.html",
        controller: "allGamesController"
    })

    $routeProvider.when("/game/:gameId", {
        templateUrl: "/Scripts/app/views/oneGame.html",
        controller: "oneGameController"
    })


    $routeProvider.otherwise({ redirectTo: "/games" });
})
// /localhost:60044/#!/game/1
app.controller("oneGameController", ["$scope", "$routeParams", "$http",
    function ($scope, $routeParams, $http) {
        console.log($routeParams);
        $http({
            method: "GET",
            url: "/api/games/" + $routeParams.gameId
        }).then(resp => {
            $scope.game = resp.data;
        })
}])


app.controller("allGamesController", ["$scope", "$http", function ($scope, $http) {
    $http({
        method: "GET",
        url: "/api/games"
    }).then(resp => {
        $scope.games = resp.data
    })
}])