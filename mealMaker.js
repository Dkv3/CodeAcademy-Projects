// Initial menu object
const menu = {
    _meal: '',
    _price: 0,
    set meal(mealToCheck) {
      if (typeof mealToCheck === "string") {
        this._meal = mealToCheck;
        return this._meal;
      } else {
        console.log("Your entry is invalid! Please enter a string.");
      }
    },
    set price(priceToCheck) {
      if (typeof priceToCheck === "number") {
        this._price = priceToCheck;
        return this._meal;
      } else {
        console.log("Your entry is invalid! Please enter a number.");
      }
    },
  };
  
  menu.meal = "fish";
  menu.price = 25;
  console.log(`Meal: ${menu.meal}`);
  console.log(`Price: ${menu.price}`);
  
  