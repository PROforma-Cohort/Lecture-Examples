const main = () => {
  const lukeUrl = "https://swapi.co/api/people/1/";

  console.log("starting request");
  fetch(lukeUrl).then((response) => {
    console.log("response came back", response);
    if (response.status === 200) {
      return response.json()
    }
  }).then((luke) => {
    console.log(luke);
    const output = document.querySelector(".luke-data")
    output.textContent = `${luke.name} has ${luke.hair_color} hair`;
    output.textContent = luke.name+" has "+ luke.hair_color + "hair";
    
  })

  console.log('fired request');

  document
    .querySelector('h1')
    .textContent += '?'
}

document.addEventListener('DOMContentLoaded', main)
