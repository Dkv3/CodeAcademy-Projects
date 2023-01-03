let team = {
    // Establish players and game data
    _players: [
      {firstName: "Bryan", lastName: "Anger", age: 34,},
      {firstName: "Dorance", lastName: "Armstrong", age: 25,},
      {firstName: "Josh", lastName: "Ball", age: 24,},
    ],
    _games: [
      {opponent: "Tamp Bay Buccaneers", teamPoints: 3, opponentPoints: 19,},
      {opponent: "Cincinnati Bengals", teamPoints: 20, opponentPoints: 17,},
      {opponent: "New York Giants", teamPoints: 23, opponentPoints: 16,},
    ],
  
  // Create getters
    get players() {
      console.log("PLAYERS:")
      let i = 0;
        while (i < this._players.length) {
        let playerVal = Object.values(this._players[i])
        console.log("-----")
        console.log(`First name: ${playerVal[0]}`)
        console.log(`Last name: ${playerVal[1]}`)
        console.log(`Age: ${playerVal[2]}`)
        i ++
        };
    },
    get games() {
      console.log("GAMES:")
      let i = 0;
        while (i < this._games.length) {
        let gameVal = Object.values(this._games[i])
        console.log("-----")
        console.log(`Opponent: ${gameVal[0]}`)
        console.log(`Team Points: ${gameVal[1]}`)
        console.log(`Opposing Team's Points: ${gameVal[2]}`)
        i ++
        };
    },
  
  // Method to add player and game data
    addPlayer(newFirstName, newLastName, newAge) {
     this._players.push({
        firstName: newFirstName,
        lastName: newLastName,
        age: newAge,
      });
    },
    addGame(newOpponent, newTeamPoints, newOpponentPoints) {
      this._games.push({
        opponent: newOpponent,
        teamPoints: newTeamPoints,
        opponentPoints: newOpponentPoints,
      });
    },
    // Addtional data would go here
  };
  
  console.log("--- Dallas Cowboys Team Points ---")
  console.log("               ")
  
  team.addPlayer("Bugs", "Bunny", 76);
  team.players;
  
  console.log("               ")
  
  team.addGame("Titans", 100, 98);
  team.games;
  