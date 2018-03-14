// implement `who won` logic
const player1Selection = (choice) => {
  const player1Choice = choice
  console.log("Player choose = " + player1Choice);
  playGame(player1Choice);
}

const playGame = (playerChoice) => {
  const computerChoice = computersSelection();
  console.log("player :" + playerChoice + " computer: " + computerChoice);
  const results = compareResults(playerChoice, computerChoice);
  displayResults(results);
}

const displayResults = (result) =>{
  alert(result);
}

const compareResults = (player1Choice, player2Choice) => {
  if (player1Choice === player2Choice) {
    return "tie";
  }
  if (player1Choice === "rock") {
    if (player2Choice === "paper") {
      return "player2";
    } else if (player2Choice === "scissor") {
      return "player1";
    }
  } else if (player1Choice === "paper") {
    if (player2Choice === "scissor") {
      return "player2";
    } else if (player2Choice === "rock") {
      return "player1";
    }
  } else if (player1Choice === "scissor") {
    if (player2Choice === "rock") {
      return "player2";
    } else if (player2Choice === "paper") {
      return "player1";
    }
  } else {
    return null;
  }
}

// after a user picks a option, the computer will select its option the site
// will then display the results

const computersSelection = () => {
  // pick at a random r/p/s
  const rand = Math.floor(Math.random() * Math.floor(3));
  console.log("picked a random number" + rand)
  if (rand === 0) {
    return "rock"
  } else if (rand === 1) {
    return "paper"
  } else {
    return "scissor"
  }
  // return a result

}