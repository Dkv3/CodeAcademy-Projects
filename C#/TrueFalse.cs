using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      string[] questions = new string[] {"Sharks are mammals.", "Bats are blind.", "Greenland is the largest island in the world.", "Pineapples grow on trees.", "The letter 'T' is the most common in the English language."};

      string [] explanations = new string [] {"False - they are classified as fish.", "False - bats can see, but not very well.", "True - Greenland is the largest island in the world.", "False - pineapples grow in the ground.", "False - E is the most common letter in the English language."};

      bool[] answers = new bool [] {false, false, true, false, false};

      RunQuiz(questions, explanations, answers);
    }

    static void RunQuiz(string[] questions, string[]explanations, bool[] answers)
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      bool[] responses = new bool[5];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning: The questions & answers array have different lengths.");
      }

      int askingIndex = 0;
      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine("\n" + question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine().ToLower();
        isBool = Boolean.TryParse(input, out inputBool);

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine().ToLower();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      int scoringIndex = 0;
      int score = 0;

      foreach (bool answer in answers)
      {
        askingIndex++;
        bool userAnswer = responses[scoringIndex];
        string trueAnswers = explanations[scoringIndex];
        Console.WriteLine($"\n{askingIndex - 5}. Your choice: {userAnswer}");
        Console.WriteLine($"Answer: {trueAnswers}");
        if (userAnswer == answer)
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"\nYou got {score} out of {scoringIndex}!");
    }
  }
}
