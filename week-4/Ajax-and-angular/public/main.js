const BASE_URL =  "https://swapi.co/api/";

angular
  .module("mainApp", [])
  .controller("mainController",['$scope', '$http',  ($scope, $http) => {
    $scope.currentName = "not yet";

    $http({
      method:"GET",
      url:BASE_URL + "films/"
    }).then(response => {
        console.log(response);
        console.log(response.data);
        $scope.movies = response.data.results;
    })

    $scope.loadMovie = (url) =>{
      console.log("loading movie", url)
      $http({
        method:"GET", 
        url:url
      }).then (response => {
        console.log("loaded movie", response)
        console.log(response.data);
        $scope.movie = response.data;
      });
    }

    $scope.loadCharacter = (url) =>{
      console.log("loading character", url)
      $http({
        method:"GET", 
        url:url
      }).then (response => {
        console.log("loaded character", response)
        console.log(response.data);
        $scope.character = response.data;
      });
    }

  }])