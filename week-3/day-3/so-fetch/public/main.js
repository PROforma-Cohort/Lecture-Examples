const main = () => {
  const lukeUrl = "https://swapi.co/api/people/1/";
 
  console.log("starting request");
  fetch(lukeUrl).then((response) => {
 
    console.log("response came back")
  })
 
  console.log('fired request');

  document.querySelector('h1').textContent += '?'
}

document.addEventListener('DOMContentLoaded', main)
