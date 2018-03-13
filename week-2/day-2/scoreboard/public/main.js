// when i click the udpate home team name button, I update the home team header
// with thee value of teh home team name textbox

const homeTeamHeader = document.querySelector("#homeTeamName");

const updateHomeTeamName = () => {
  console.log("clicked update home team name button");
  const newName = document
    .querySelector("#homeTeamNameTextBox")
    .value;
  console.log("queried for name", newName);
  homeTeamHeader.textContent = newName;
}

// As a user, when i click the `add score` button, it adds one to the home team
// score get the current update the current save the current back to the DOM
// Approach 1
let homeScore = 0;
let awayScore = 0;
const homeScoreTag = document.querySelector('#homeTeamScore')

const homeTeamAddScoreClick = () => {
  console.log("home team add score button clicked")
  homeScore++;
  homeScoreTag.textContent = homeScore;

  // log the current time, add this to a list
  let quarterSuffix = "";
  switch (currentQuarter) {
    case 1:
      quarterSuffix = "st"
      break;
    case 2:
      quarterSuffix = "nd"
      break;
    case 3:
      quarterSuffix = "rd"
      break;
    default:
      quarterSuffix = "th"
      break;
  }
  // if (currentQuarter === 1 || currentQuarter === 21){   quarterSuffix = "st"; }
  // else if (currentQuarter === 2 || currentQuarter === 22){   quarterSuffix =
  // "nd" } else if (currentQuarter == 3){   quarterSuffix = "rd" } else {
  // quarterSuffix = "th" }
  const message = "Home team scored at " + currentTime + " in the " + currentQuarter;
  const newTag = document.createElement("li");
  newTag.textContent = message;
  document
    .querySelector("#scoreLog")
    .appendChild(newTag);
}

// when a user clicks the score button, we add that time to a list to log who
// score when
const homeTeamRemoveScoreClick = () => {
  console.log("home team remove score button clicked")
  homeScore--;
  homeScoreTag.textContent = homeScore;
}

const homeTeamAddScoreClick_2 = () => {
  console.log("home team add score button clicked 2")
  let currentScore = homeScoreTag.textContent;
  currentScore += 1;
  /*
    currentScore = currentScore + 1
  */
  homeScoreTag.textContent = currentScore;
}

// As a user, when i click the `subtract score` button, it subtracts one to the
// home team score as the system when the page loads, the countdown timer should
// start counting down when the counter hits zero, the scoreboard should alrt
// the user how to do quarters?!?!? when the timer hits 0, we want increment a
// quarter count only 4 quarters, starts at 1 we do not want the next quarter to
// automatically start timer to reset

let currentTime = 5; // seconds
let currentQuarter = 1;

const timerElement = document.querySelector(".seconds");
const quarterElement = document.querySelector(".quarter");
const startButton = document.querySelector("#startButton");

const timerCountdown = () => {
  console.log("updating timer")
  /*
    if ( boolean condition){
      // some code
    } else if (boolean condition){
      // some code
    } else {
      // some code
    }
  */

  // true-y anything that is defined false-y false, 0, "" , null, undefined
  if (currentTime == 0) {
    console.log("time is up")
    currentQuarter++;
    if (currentQuarter > 1) {
      // this will be 5, (4 +1 ) hides the next quarter start
      startButton
        .classList
        .add("hide");
      // alert the winner home score compare to away score
      if (homeScore > awayScore) {
        alert("home team won!")
      } else if (homeScore < awayScore) {
        alert("away team won")
      } else {
        alert("Tie!")
      }
    }
    quarterElement.textContent = currentQuarter;
    // stop timer
    clearInterval(timerInterval);
    currentTime = 5;
  } else {
    currentTime--;
    timerElement.textContent = currentTime;
  }
}

let timerInterval;
const main = () => {
  timerInterval = setInterval(timerCountdown, 1000);
}


const generatesRandomStartingScoreForTheHomeTeam = () => {
  
} 