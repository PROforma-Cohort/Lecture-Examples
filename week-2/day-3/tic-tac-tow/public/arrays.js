// Arrays!
// I want to store all the past plays of player 1

// list (ul) in HTML
let player1FirstChoice = "";
let player1SecondChoice = "";
let player1ThirdChoice = "";
let player1FourthChoice = "";


let allPlayer1Choices = [];

allPlayer1Choices.push("rock");
allPlayer1Choices.push("paper");
allPlayer1Choices.push("rock");
allPlayer1Choices.push("scissor");
allPlayer1Choices.push("paper");

// ["rock", "paper", "rock", "scissor", "paper"]

const firstChoice = allPlayer1Choices[0];

console.log(allPlayer1Choices[0])
console.log(allPlayer1Choices[1])
console.log(allPlayer1Choices[2])
console.log(allPlayer1Choices[3])
console.log(allPlayer1Choices[4])


// Loops

// for(defining our counter & starting point; when to stop; how are affect the index){

// }

for (let i = 0; i <= 5; i++) {
    console.log(i, allPlayer1Choices[i]);
}

/**
 * 0, rock
 * 1, paper
 * 2, rock
 * 3, scissor
 * 4, rock
 * 5, undefined
 */

 for (let i = 0; i < allPlayer1Choices.length; i++) {
     const element = allPlayer1Choices[i];
     
 }

// while


let gameCount = 0;
while ((playerWinCount < 2 && computerWinCount < 2) || gameCount < 3) {
    playGame()
    gameCount++;
}
printBestOf3Results();


let seconds = 0;
let timerStarted = false;


timerStarted = true;

while (timerStarted){
    seconds++;
}