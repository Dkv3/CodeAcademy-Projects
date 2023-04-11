using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      // Let the user know that the program is starting:
      Console.WriteLine("Initializing Mad Libs...");

      // Give the Mad Lib a title:
      string title = "-- Floppa's Day Out-- ";
      Console.WriteLine(title);

      
      // Define user input and variables:
      //Console.Write("Enter a name: ");
      //string name = Console.ReadLine();
      string name = "Floppa";
      Console.WriteLine("Enter 3 adjectives:");
      Console.Write("Adjective 1: ");
      string adj1 = Console.ReadLine();
      Console.Write("Adjective 2: ");
      string adj2 = Console.ReadLine();
      Console.Write("Adjective 3: ");
      string adj3 = Console.ReadLine();

      Console.WriteLine("Enter 1 verb:");
      Console.Write("Verb: ");
      string verb = Console.ReadLine();

      Console.WriteLine("Enter 2 nouns:");
      Console.Write("Noun 1: ");
      string noun1 = Console.ReadLine();
      Console.Write("Noun 2: ");
      string noun2 = Console.ReadLine();

      Console.WriteLine("Enter a value for each of the following:");
      Console.Write("An animal: ");
      string animal = Console.ReadLine();
      Console.Write("A food: ");
      string food = Console.ReadLine();
      Console.Write("A fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("A superhero: ");
      string hero = Console.ReadLine();
      Console.Write("A country: ");
      string country = Console.ReadLine();
      Console.Write("A dessert: ");
      string des = Console.ReadLine();
      Console.Write("A year: ");
      string year = Console.ReadLine();
      

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {des}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
