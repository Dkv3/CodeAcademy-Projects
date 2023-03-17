using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*";
      int score = 0;

      string strength = "";
      string adj = "a";

      Console.Write("Enter a password: ");
      string pass = Console.ReadLine();

      if (pass.Length >= minLength) 
      {
        score++;
      }
      if (Tools.Contains(pass, uppercase))
      {
        score++;
      }
      if (Tools.Contains(pass, lowercase))
      {
        score++;
      }
      if (Tools.Contains(pass, digits))
      {
        score++;
      }
      if (Tools.Contains(pass, specialChars))
      {
        score++;
      } 
      if (pass == "password" || pass == "1234")
      {
        score = 0;
      }

      switch (score)
      {
        case 5:
          strength = "Very Strong";
          break;
        case 4:
          strength = "Very Strong";
          break;
        case 3:
          strength = "Strong";
          break;
        case 2:
          strength = "Medium";
          break;
        case 1:
          strength = "Weak";
          break;
        case 0:
          strength = "Invalid";
          adj = "an";
          break;
        default:
          strength = "Undefined";
          adj = "an";
          break;
      }
      Console.WriteLine($"Your password has a score of {score}. It is {adj} {strength} password!");
    }
  }
}
