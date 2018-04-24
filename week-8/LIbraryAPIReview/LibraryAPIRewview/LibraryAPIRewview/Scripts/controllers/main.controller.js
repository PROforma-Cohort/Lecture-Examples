app.controller("mainController", ["$scope", "$http", ($scope, $http) => {
    $scope.currentTime = new Date();
    $scope.title = "main page";
    $http({
        method: "PUT",
        url: "/api/book"
    }).then(resp => {
        console.log(resp.data);
        $scope.books = resp.data;
    })
}]);