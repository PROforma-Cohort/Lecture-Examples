// OLD angular.module("main", []).controller("mainController", ["$scope",
// ($scope) =>{}])

const app = angular.module("main", []);

app.service("calculatorLogic", function () {
  this.add = (x, y) => {
    return parseInt(x) + parseInt(y);
  }
  this.subtract = (x, y) => {
    return parseInt(x) - parseInt(y);
  }
});

app.service("advancedCalculator", function () {
  this.add = (numbers) => {
    return numbers.reduce((a, i )=> a + parseInt(i), 0)
  }
})

app.filter("formatAnswer", function() {
  return (text) =>{
    return "Your answer is " + text;
  }
})

app.controller("mainController", [
  "$scope",
  "calculatorLogic",
  "advancedCalculator",
  ($scope, calculatorLogic, advancedCalculator) => {
    // onclicks UI values
    $scope.number1 = 0;
    $scope.number2 = 0;
    $scope.number3 = 0;
    $scope.answer = 0;

    $scope.answerIsPostive = $scope.answer > 0;

    $scope.names = [ "tammy", "tim", "bob", "pap", "benny"]


    $scope.otherAdd = () => {
      const arr = [$scope.number1, $scope.number2, $scope.number3];
      console.log(arr);
      $scope.answer = advancedCalculator.add(arr);
    }
    $scope.addNumbers = () => {
      $scope.answer = calculatorLogic.add($scope.number1, $scope.number2);
    }
    $scope.subtractNumbers = () => {
      $scope.answer = calculatorLogic.subtract($scope.number1, $scope.number2);
    }
  }
])