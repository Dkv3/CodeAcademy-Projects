using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    private int Age
    {
      get { return age; }
      set {
        if (value < 18)
        {
          Console.WriteLine("You must be 18 years or older to sign up.");
          Environment.Exit(0);
        } else {
          age = value;
        }
      }
    }

    public Profile(string name, int age, string city = null, string country = null, string pronouns = null, string[] hobbies = null)
    {
      this.name = name;
      Age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = hobbies ?? new string[0];
    }
    
    public string ViewProfile()
    {
      string bio = $"Name: {this.name}\nAge: {this.age}\nCity: {this.city}\nCountry: {this.country}\nPronouns: {this.pronouns}";

      bio += "\nHobbies:";
      // Either for loop works
      /*
      for (int i = 0; i < this.hobbies.Length; i++)
      {
        bio += $"\n- {this.hobbies[i]}";
      }*/
      foreach (string hobby in this.hobbies)
      {
        bio += $"\n- {hobby}";
      } 
      return bio;
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}
