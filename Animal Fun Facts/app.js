import { animals } from "./animals";
import React from "react";
import ReactDOM from "react-dom";

const title = "";

const background = (
  <img class="background" alt="ocean" src={"/images/ocean.jpg"} />
);

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
  const index = Math.floor(Math.random() * 1);
  const funFact = 'animals.selectedAnimal.facts';
  document.getElementById('fact').innerHTML = funFact;
  console.log(`funFact: ${funFact}`);
  console.log(`index: ${index}`);
  console.log(`selectedAnimal: ${selectedAnimal}`);
  console.log(`animals.selectedAnimal:`, animals.selectedAnimal);
  console.log('Dolphin fact:', animals.dolphin.facts[0]);
}

// (line 36): animals.selectedAnimal isn't real; need to find a way to use the actual variable, selectedAnimal, instead of the literal property name that isn't actually there

const animalFacts = (
  <div>
    <h1>{title}</h1>
    {title === "" ? "Click an animal for a fun fact!" : title}
    {background}
    <div className="animals">{images}</div>
    <p id='fact'></p>
  </div>
);

ReactDOM.render(animalFacts, document.getElementById("root"));
