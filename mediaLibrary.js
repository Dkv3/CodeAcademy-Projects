class Media {
    constructor(title) {
      this._title = title;
      this._isCheckedOut = false;
      this._ratings = [];
    }
  
    get title() {
      return this._title;
    }
  
    get isCheckedOut() {
      return this._isCheckedOut;
    }
  
    get ratings() {
      return this._ratings;
    }
  
    set isCheckedOut(state) {
      this._isCheckedOut = state;
    }
  
    toggleCheckOutStatus() {
      if (this._isCheckedOut === true) {
        return (this._isCheckedOut = false);
      } else if (this._isCheckedOut === false) {
        return (this._isCheckedOut = true);
      }
    }
  
    getAverageRating() {
      let ratingsTotal = this._ratings.reduce(
        (currentSum, rating) => currentSum + rating, 0);
      let ratingsAvg = ratingsTotal / this._ratings.length;
      return (`Average Rating: ${Math.round(ratingsAvg * 10) / 10}`)
    }
  
    addRating(newRating) {
      if (typeof newRating === "number" && newRating >= 0 && newRating <= 5) {
        this._ratings.push(newRating);
      } else {
        return "Please enter a number between 1 and 5."
      }
    }
  
    checkoutStatus() {
      if (this._isCheckedOut === true) {
        return `"${this._title}" - This ${this.constructor.name} is checked out.`
      } else if (this._isCheckedOut === false) {
        return `"${this._title}" - This ${this.constructor.name} is not checked out.`
      }
    }
    // Media class ends here
  }
  
  class Book extends Media {
    constructor(title, author, pages) {
      super(title);
      this._author = author;
      this._pages = pages;
    }
  
    get author() {
      return this._author;
    }
  
    get pages() {
      return this._pages;
    }
    // Book subclass ends here
  }
  
  class Movie extends Media {
    constructor(title, director, runTime) {
      super(title);
      this._director = director;
      this._runTime = runTime;
    }
  
    get director() {
      return this._director;
    }
  
    get runTime() {
      return this._runTime;
    }
    // Movie subclass ends here
  }
  
  // Using the classes and logging the results:
  const historyOfEverything = new Book("A Short History of Nearly Everything", "Bill Bryson", 544);
  historyOfEverything.toggleCheckOutStatus();
  console.log(historyOfEverything.checkoutStatus());
  historyOfEverything.addRating(4);
  historyOfEverything.addRating(5);
  historyOfEverything.addRating(5);
  console.log(historyOfEverything.getAverageRating());
  
  console.log("-----")
  
  const speed = new Movie("Speed", "Jan de Bont", 116);
  speed.toggleCheckOutStatus();
  console.log(speed.checkoutStatus());
  speed.addRating(1);
  speed.addRating(1);
  speed.addRating(5);
  console.log(speed.getAverageRating());
  
  