using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "He/Him");
      sam.SetHobbies(new string[] { "Listening to audiobooks and podcasts", "Playing rec sports like bowling and kickball", "Writing a speculative fiction novel", "Reading advice columns" });
      Console.WriteLine(sam.ViewProfile());
      Console.WriteLine("");
      
      Profile flop = new Profile("Big Floppa", 18);
      Console.WriteLine(flop.ViewProfile());
    }
  }
}
