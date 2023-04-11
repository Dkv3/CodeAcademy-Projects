import { animals } from "./animals";
import React from "react";
import ReactDOM from "react-dom";

const title = "";

const background = (
  <img class="background" alt="ocean" src={"/images/ocean.jpg"} />
);

const showBackground = true;

const images = [];
for (const animal in animals) {
  images.push(
    <img
      key={animal}
      className="animal"
      alt={animal}
      src={animals[animal].image}
      aria-label={animal}
      role='button'
      onClick={displayFact}
    />
  );
}

console.log(animals.dolphin.facts[0]);

function displayFact(e) {
  const selectedAnimal = e.target.alt;
  const animalInObject = animals[selectedAnimal];
  const index = Math.floor(Math.random() * animalInObject.facts.length);
  const funFact = animalInObject.facts[index];
  document.getElementById('fact').innerHTML = funFact;
}

const animalFacts = (
  <div>
    <h1>{title}</h1>
    {/*  {title === "" ? "Click an animal for a fun fact!" : title}*/}
    {title || "Click an animal for a fun fact!"}
    {showBackground && background}
    <div className="animals">{images}</div>
    <p id='fact'></p>
  </div>
);

ReactDOM.render(animalFacts, document.getElementById("root"));

//     {title === "" ? "Click an animal for a fun fact!" : title}
