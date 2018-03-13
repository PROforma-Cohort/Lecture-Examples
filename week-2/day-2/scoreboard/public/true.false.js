let x = 5;
let y = 10;
let z = 11;
let w = 1;

// <, <=, >, >=, ===, == &&, ||
if (x < y && (w > z && x == y)) {
    // do something
}

// refactor option B:
let conditionA = x < y;
let conditionB = w > z;
let conditionC = x == y;
let isValid = conditionB && conditionC;

console.log(conditionA, conditionB, conditionC)
if (conditionA && isValid) {
}

// refactor, option A:
if (w > z && x == y) {
    if (x < y){

    } else {

    }
} else {

}