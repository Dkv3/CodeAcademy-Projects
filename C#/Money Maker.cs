using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Coin Conversion");

      // Prompts for user
      Console.WriteLine("Enter an amount (in cents) to convert to the lowest-possible amount of coins: ");
      Console.WriteLine("1 Dollar Coin = 100 Cents");
      Console.WriteLine("1 Half Dollar = 50 Cents");
      Console.WriteLine("1 Quarter = 25 Cents");
      Console.WriteLine("1 Dime = 10 Cents");
      Console.WriteLine("1 Nickle Coin = 5 Cents");
      Console.WriteLine("1 Penny = 1 Cent");
      Console.Write("> ");

      // Store and convert input from string to double
      string input = Console.ReadLine();
      double amount = Math.Floor(Convert.ToDouble(input));

      // Define coin values
      double dollar = 100;
      double half = 50;
      double quart = 25;
      double dime = 10;
      double nickel = 5;
      double penny = 1; 

      // Calculate values
      double dollarCoins = Math.Floor(amount / dollar);
      double remainder = amount % dollar;
      double halfCoins = Math.Floor(remainder / half);
      remainder = remainder % half;
      double quartCoins = Math.Floor(remainder / quart);
      remainder = remainder % quart;
      double dimeCoins = Math.Floor(remainder / dime);
      remainder = remainder % dime;
      double nickelCoins = Math.Floor(remainder / nickel);
      remainder = remainder % nickel;
      double pennyCoins = Math.Floor(remainder / penny);
      remainder = remainder % penny;

      // Display values
      Console.WriteLine($"{amount} is equal to...");
      Console.WriteLine($"Dollar Coins: {dollarCoins}");
      Console.WriteLine($"Half Dollar Coins: {halfCoins}");
      Console.WriteLine($"Quarters: {quartCoins}");
      Console.WriteLine($"Dimes: {dimeCoins}");
      Console.WriteLine($"Nickels: {nickelCoins}");
      Console.WriteLine($"Pennies: {pennyCoins}");

    }
  }
}
