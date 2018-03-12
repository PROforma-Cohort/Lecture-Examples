const main = () => {
  const x = "5";
  let message = "i like food";

  console.log(typeof x);
  console.log(typeof message);

  // CAN'T CHANGE VALUE SINCE ITS CONST: x = "123";
  message = 123;
  console.log(typeof message);

  console.log("Hello, world!");

  //
  console.log("insided main", x);

  // DONT USE: var z = 10;

  const total1 = 5 + 4;
  const total2 = 5 / 4;
  const total3 = 5 * 4;
  const total4 = 5 - 4;


  const output = "Hello, " + "world";

  
  /* varible naming rules
  start with a letter or _ or $
  after that that, a letter, _, or a number
  */
 
 const myHeader = document.querySelector("h1");
 
 console.log("before", typeof myHeader.textContent);
 
 myHeader.textContent = 8675309;
 console.log("after", typeof myHeader.textContent);

 // document.querySelectorAll('h1').textContent = document.querySelectorAll('h1').textContent +  '?'

 document.querySelector('h1').textContent += "?";


 // add event here: 
}

let count = 0;

const clicked = () =>{

  count++; // => count += 1  => count = count + 1
  console.log("Button Was Clicked");
  const myHeader = document.querySelector('h1');
  myHeader.textContent = "Button was Clicked " + count +" times";
}

document.addEventListener("DOMContentLoaded", main);

// this errors out -- because scope console.log("outside main", x);