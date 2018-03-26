const API_KEY = "ac9714c1ba65de61949a81a9c0959b33";
const API_URL = `http://api.openweathermap.org/data/2.5/weather?appid=${API_KEY}`

/**
 * Localstorage
 *
 */

const storePastWeather = (pastWeather) => {
  localStorage.setItem("last-search", pastWeather)
}

const getPastWeather = () => {
  return localStorage.getItem("last-search");
}

const getWeather = (lat, lon) => {
  const _url = API_URL + "&lat=" + lat + "&lon=" + lon;
  console.log("url", _url);
  fetch(_url).then(resp => {
    if (resp.status === 200) {
      return resp.json();
    } else {
      // something went wrong with the AJAX
      const errorContainer = document.querySelector("#errorMessage")
      const _li = document.createElement('li');
      const msg = "There was issue talking to the weather API";

      _li.textContent = msg;
      errorContainer.appendChild(_li);
      throw new Error(msg);
    }
  }).then((weatherData) => {
    const parent = document.querySelector(".weather-output");
    const weatherMessage = `The weather is ${weatherData.weather[0].main} at ${weatherData.name}`
    parent.textContent = weatherMessage;
    storePastWeather(weatherMessage + " at " + new Date());
  }).catch((err) => {
    console.log("error was caught");
    console.log(err);
    // TODO: we log the error local storate or our server,
  })
}

const main = () => {
  console.log("main is running")

  const parent = document.querySelector(".history")
  const lastResults = getPastWeather();
  if (lastResults){
    parent.textContent = lastResults
  } else {
    parent.textContent = "No last search";
  }

  if ("geolocation" in navigator) {
    /* geolocation is available */
    console.log("geolocation is enabled")
    getWeather(31, -75);
    // navigator.geolocation.getCurrentPosition((position) => {
    // console.log(position);   getWeather(position.coords.latitude,
    // position.coords.longitude); }, (err) => {   console.log("err", err); })
  } else {
    console.log("no geo locations")

    /* geolocation IS NOT available */
  }
}

document.addEventListener('DOMContentLoaded', main)
