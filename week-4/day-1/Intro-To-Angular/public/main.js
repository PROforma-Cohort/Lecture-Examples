const getRandomNumber = () => {
  return Math.ceil(Math.random() * 10);
}


angular.
  module("helloWorldApp",[])
  .controller("mainController", ($scope) => {
    
    // not able to be used in the DOM
    const message = "Goodbye";
    
    
    $scope.currentTime = new Date();
    $scope.displayName ="";
    $scope.updateName = () => {
      $scope.displayName = $scope.name + " " + getRandomNumber();
    }

    // $scope.searchValue = "This should go into my search box";
    // console.log($scope.searchValue);
    console.log($scope);
  })
  .controller("otherController", ($scope) =>{
    
  });



