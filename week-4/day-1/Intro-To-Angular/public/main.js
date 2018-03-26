const getRandomNumber = () => {
  return Math.ceil(Math.random() * 10);
}


angular
  .module("helloWorldApp",[])
  .controller("mainController", ($scope) => {
    
    // not able to be used in the DOM
    const message = "Goodbye";
    
    
    $scope.currentTime = new Date();
    $scope.displayName ="";
    $scope.updateName = () => {
      $scope.displayName = $scope.name + " " + getRandomNumber();
    }


    $scope.numbers = [1,2,3,4,5]
    $scope.addRandomNumber = () => {
      $scope.numbers.push(getRandomNumber());
    }

    $scope.update3Value = () => {
      $scope.numbers[2] +=  3
    }
    $scope.addOneToThisValue = (index) => {
      $scope.numbers[index] += 1;
    }





    // $scope.searchValue = "This should go into my search box";
    // console.log($scope.searchValue);
    console.log($scope);
  })
  .controller("otherController", ($scope) =>{

  });



