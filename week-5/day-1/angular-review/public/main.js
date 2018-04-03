const app = angular.module("main", []);
const CATEGORY_API = "http://jservice.io/api/category?id="

app.controller("mainController", [
  "$scope",
  "$http",
  ($scope, $http) => {

    $scope.title = "Hello world!!!"
    $scope.player = {
      score: 0
    }
    $scope.game = {
      categories: []
    }
    const getCategory = (id) => {
      $http({
        method: "GET",
        url: CATEGORY_API + id
      }).then(response => {
        console.log("back from API,", response.data);
        const _category = {
          title: response.data.title,
          clues: response
            .data
            .clues
            .slice(0, 5)
        }
        _category.clues = _category
          .clues
          .map((clue, index) => {
            clue.value = (index + 1) * 100;
            return clue;
          })
        console.log(_category)
        $scope.game.categories.push(_category);
        console.log($scope.game);
      })

    }
    
    $scope.questionSelected = (clue) => {
      console.log("asking", clue);
      $scope.questionWasSelected = true;
      $scope.selectedQuestion = clue;
    }

    $scope.checkAnswer = () => {
      // compare, userAnswer with selectedQuestionAnswer
      const isCorrect = $scope
        .userAnswer
        .toLowerCase() === $scope
        .selectedQuestion
        .answer
        .toLowerCase()
      if (isCorrect) {
        // increase player score by current value
        $scope.player.score += parseInt($scope.selectedQuestion.value)
      } else {
        //decrease player score by current value
        $scope.player.score -= parseInt($scope.selectedQuestion.value)
      }
      $scope.questionWasSelected = false;
      $scope.selectedQuestion.answered = true;
    }
    const init = () => {
      const _categories = [1,2,3,4,5,6]
      _categories.forEach(id => {
        getCategory(id);
      })
    }
    init();
   
  }
])