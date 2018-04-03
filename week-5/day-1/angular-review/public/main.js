const app = angular.module("main", []);
const CATEGORY_API = "http://jservice.io/api/category?id=3228"

app.controller("mainController", [
  "$scope",
  "$http",
  ($scope, $http) => {

    $scope.title = "Hello world!!!"
    $scope.player = {
      score:0
    }

    $http({method: "GET", url: CATEGORY_API}).then(response => {
      console.log("back from API,", response.data);
      // category title category clues (values & questions)
      // 5 quetsions, 
        // 100
        // 200
        // 300
        // 400
        // 500
      $scope.category = {
        title: response.data.title,
        clues: response.data.clues.slice(0, 5)
      }
      $scope.category.clues = $scope.category.clues.map((clue, index) => {
        clue.value = (index  + 1) * 100;
        return clue;
      })
      console.log($scope.category)
    })

    $scope.questionSelected = (clue) => {
      console.log("asking", clue);
      $scope.questionWasSelected = true;
      $scope.selectedQuestion = clue; 
    }

    $scope.checkAnswer = () => {
      // compare, userAnswer with selectedQuestionAnswer
      const isCorrect = $scope.userAnswer.toLowerCase() === $scope.selectedQuestion.answer.toLowerCase()
      if (isCorrect){
        // increase player score by current value
        $scope.player.score += parseInt($scope.selectedQuestion.value)
      } else {
        //decrease player score by current value
        $scope.player.score -= parseInt($scope.selectedQuestion.value)
      }
      $scope.questionWasSelected = false;
      $scope.selectedQuestion.answered = true;
    }
  }
])