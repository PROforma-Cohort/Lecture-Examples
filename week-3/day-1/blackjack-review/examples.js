const arr = [
    1,
    2,
    3,
    4,
    5,
    6
];

// map
const results = arr.map((item) => {
    return item * item;
})
results == [
    1,
    4,
    9,
    16,
    25,
    36
]

// fitler
const evens = arr.filter((item) => {
    return item % 2 == 0;
})

evens == [2, 4, 6]
// reduce this does an action on a each item of array, and runs a computation
// funttion (like sum) find
// marks = [2,3,5,4]

function getAverage(marks){
    //   const total  = marks.reduce([function],[starting point]);
    
    // creating an anonymous function 
    return Math.floor(marks.reduce((a, i) => {return a + i}) / marks.length);
    
    //  // find sum
    //  let total = 0;
    //  for (let i = 0; i < marks.length; i++){
    //    total += marks[i];
    //  }
     
    //  // divide by total
    //  let avg = total /marks.length;
     
    //  // round down. 
    //  return Math.floor(avg) 
    }


const first = arr.find((item) => {
    return item % 4 == 0;
})

first === 4

const people = [
    {
        name: "paul",
        age: 25
    }, {
        name: "pap",
        age: 76
    }, {
        name: "sam",
        age: 34
    }, {
        name: "tim",
        age: 44
    }, {
        name: "lucy",
        age: 66
    }, {
        name: "chelsie",
        age: 14
    }
]

// map create a welcome mesage for each person
const messages = people.map((person) => {
    return `Hello, ${person.name}. You are ${person.age} years old!`
})
// filter all people that can order from the kids menu
const kids = people.filter((person) => {
    return person.age < 18;
})
// find find the first named pap
const pap = people.find((person) => {
    return person.name === "pap"
})
// reduce

const arrayOrArrays = [
    [2,4,5,7],
    [7,65,45,3]
]

// pull out thirs item of each

const thirds = arrayOrArrays.map((arr) => {
    return arr[2];
})

const thirds = [];
for (let i = 0; i < arrayOrArrays.length; i++) {
    const arr = arrayOrArrays[i];
    thirds.push(arr[2]);
}