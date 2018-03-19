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

const dealInitHand = () =>{
 return [shuffledDeck.pop(), shuffledDeck.pop()];
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
  console.log(hand);
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
}