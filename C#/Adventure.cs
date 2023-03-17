using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      bool firstInput = true;
      bool secondInput = true;
      string noiseChoice = "";
      string doorChoice = "";

      Console.WriteLine("What is your name?");
      Console.Write("> ");
      string name = Console.ReadLine();

      Console.WriteLine($"Hello, {name}! Welcome to the story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

      while (firstInput)
      {
        Console.WriteLine("Y / N");
        Console.Write("> ");
        noiseChoice = (Console.ReadLine().ToUpper());
        if (noiseChoice == "Y" || noiseChoice == "N")
        {
          firstInput = false;
        } else
        {
          Console.WriteLine("You must enter either Y or N.");
          firstInput = true;
        }
      }


      if (noiseChoice == "N")
      {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END.");
      }
      else if (noiseChoice == "Y")
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");

        while (secondInput)
        {
          Console.WriteLine("Knock / Open");
          Console.Write("> ");
          doorChoice = (Console.ReadLine().ToUpper());
          if (doorChoice == "KNOCK" || doorChoice == "OPEN")
          {
            secondInput = false;
          } else
          {
            Console.WriteLine("You must enter either Knock or Open.");
            secondInput = true;
          }
        }

        if (doorChoice == "KNOCK")
        {
          Console.WriteLine("A voice behind the door speaks. It says,");
          Console.WriteLine("Answer this riddle:");
          Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?");
          Console.WriteLine("Type your answer:");
          Console.Write("> ");
          string riddleAnswer = (Console.ReadLine().ToUpper());
          if (riddleAnswer == "NOTHING")
          {
            Console.WriteLine("The door opens and NOTHING is there.");
            Console.WriteLine("You turn off the light and run back to your room and lock the door.");
            Console.WriteLine("THE END.");
          }
          else
          {
            Console.WriteLine("You answered incorrectly. The door doesn't open.");
            Console.WriteLine("THE END.");
          }
        } // Closes KNOCK
        else if (doorChoice == "OPEN")
        {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          Console.WriteLine("Enter a number (1-3):");
          Console.Write("> ");
          string keyChoice = Console.ReadLine();
          switch (keyChoice) {
            case "1":
              Console.WriteLine("You choose the first key. Lucky Choice!");
              Console.WriteLine("The door opens and NOTHING is there.");
              Console.WriteLine("Strange...");
              Console.WriteLine("THE END.");
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open.");
              Console.WriteLine("THE END.");
              break;
            default:
              break;
          } // Closes switch statement
        } // Closes OPEN
      } // Closes Y
     
    } // Rest of these close the program
  }
}