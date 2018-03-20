const cardData = {
  suits: [
    "spades", "hearts", "clubs", "diamonds"
  ],
  numbers: [
    "ace",
    "2",
    "3",
    "4",
    "5",
    "6",
    "7",
    "8",
    "9",
    "10",
    "j",
    "q",
    "k"
  ]
}

let unShuffledDeck = [];
let shuffledDeck = [];
// TODO: add score 
// TODO: add money
// TODO: add win/lose record
const player1 = {
  name: "",
  hand: [],
};

const house = { name: "house", hand: [],};


const createDeck = () => {
  unShuffledDeck = [];
  for (let i = 0; i < cardData.suits.length; i++) {
    const suit = cardData.suits[i];
    for (let j = 0; j < cardData.numbers.length; j++) {
      const rank = cardData.numbers[j];
      const card = {
        suit: suit,
        rank: rank
      }
      unShuffledDeck.push(card);
    }
  }
}

const getRandomNumber = (max) => {
  return Math.floor(Math.random() * max);
}
const shuffle = () => {
  // 52 times
  while (unShuffledDeck.length >0){ // pull a random card
    const pos = getRandomNumber(unShuffledDeck.length);
    const randCard = unShuffledDeck[pos];
    // insert card in shuffled deck
    console.log(randCard);
    // push inserts at the end
    // unshift inserts at the begining
    shuffledDeck.push(randCard);
    // remove card from unshuffled deck
    // splice
    unShuffledDeck.splice(pos, 1);
  }
}

// IDEA: make a new function to deal 1 card and use that 
const getTopXCardsFromDeck = (number) => {
  const newCards = [] ;
  for (let i = 0; i < number; i++) {
    newCards.push(shuffledDeck.pop())    
  }
  return newCards;
}
//IDEA: duplicate logic in hand 
// IDEA: pass a parameter with a number of cards to deal 
const dealInitHand = () =>{
 return getTopXCardsFromDeck(2);
}

const dealStartingHandToPlayer = () => {
  // take 2 cards from shuffled deck
  player1.hand = dealInitHand();
  // put in a players hand
}
const dealStartingHandToHouse = () => {
  house.hand = dealInitHand();
}

const addHandToDOM = (parentClass, hand) => {
  const parent = document.querySelector(parentClass)
  // foreach item in player hand, 
  console.log("add hand to dom: ", hand);
  parent.textContent = "";
  for (let i = 0; i < hand.length; i++) {
    const card = hand[i];
    // create a new element, add it to the list
    const _li = document.createElement("li");
    _li.textContent = card.rank + " of " + card.suit;
    parent.appendChild(_li);
  }
}

const hideElement = (selector) => {
  const btn = document.querySelector(selector);
  btn.classList.add("hide");
}

const getCardValue = (card) => {
  let value = 0;
  if (card.rank == "ace"){
    value = 11;
  } else if (card.rank == "k" || card.rank == "q" || card.rank == "j"){
    value = 10
  } else {
    value = parseInt(card.rank);
  }
  return value;
}

// 3 clubs, 7 of hearts
const calculateHandTotal = (hand) => {
    return hand.reduce((total, card) => {
        return total += getCardValue(card);
    },0);

    let total = 0;
    for (let i = 0; i < hand.length; i++) {
      const card = hand[i];
      total += getCardValue(card);
    }
    return total; 
}

const hitLogic = () => {
  console.log("hit was clicked");
  // deal our cards
  player1.hand = player1.hand.concat(getTopXCardsFromDeck(1));
  //update the player hand on the screen
  addHandToDOM(".player-hand", player1.hand);
  // calculate hand total

  // check if busted 
}

const addHitOrStayButtons = () => {
  const hitButton  = document.createElement("button"); 
  hitButton.textContent = "hit me";
  
  hitButton.onclick = hitLogic;

  const stayButton  = document.createElement("button"); 
  stayButton.textContent = "stay"

  stayButton.onclick = () => {
    console.log("stay was clicked");
  }
  const parent = document.querySelector(".player-buttons");
  parent.appendChild(hitButton);
  parent.appendChild(stayButton);
}

const startGame = () => {
  console.log("starting Game");
  createDeck();
  console.log("deck : ", unShuffledDeck);
  shuffle();
  console.log("shuffled: ",shuffledDeck );
  dealStartingHandToPlayer()
  dealStartingHandToHouse()
  console.log(player1, house);
  addHandToDOM(".player-hand", player1.hand)
  addHandToDOM(".house-hand", house.hand)
  hideElement("#startButton");
  addHitOrStayButtons();
}
