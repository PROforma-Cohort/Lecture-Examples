console.log("hello world");


angular.
    module("helloWorldApp", [])
    .controller("mainController", ["$scope", "$http", ($scope, $http) => {
        $scope.currentTime = new Date();
        $http({
            method: "GET",
            url:"/api/book"
        }).then(resp => {
            console.log(resp.data);
            $scope.books = resp.data;
        })
    }]);

