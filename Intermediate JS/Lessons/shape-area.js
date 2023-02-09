// shape-area.js is meant to interact with app.js

/* shape-area.js */
const PI = Math.PI;

// Define and export circleArea() and squareArea() below
const circleArea = (radiusLength) => PI * Math.pow(radiusLength, 2);

const squareArea = (sideLength) => Math.pow(sideLength, 2);

module.exports.circleArea = circleArea;
module.exports.squareArea = squareArea;