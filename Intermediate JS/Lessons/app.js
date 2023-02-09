// shape-area.js is meant to interact with app.js

/* app.js */ 
const radius = 5;
const sideLength = 10;

const { circleArea, squareArea } = require("./shape-area.js")

const areaOfCircle = circleArea(radius);

const areaOfSquare = squareArea(sideLength);