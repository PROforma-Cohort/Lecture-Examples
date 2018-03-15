const game = {
  player:"",
  computer: "",
  gameCounter:0
}


// implement `who won` logic
const player1Selection = (choice) => {
  game.player = choice;
  choice = game.player;
  console.log("Player choose = " + game.player);
  playGame();
}

const playGame = () => {
  game.computer = computersSelection();
  console.log("player :" + game.player + " computer: " + game.computer);
  const results = compareResults(game);
  game.gameCounter++;
  displayResults(results);
}

const displayResults = (result) =>{
  alert(result);
}

const compareResults = (game) => {
  const player1Choice = game.player;
  const player2Choice = game.computer;

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