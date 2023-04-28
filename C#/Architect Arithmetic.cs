using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      CalculateTotalCost();
    }
    
    public static void CalculateTotalCost()
    {
      // Console.WriteLine("The area of a rectangle with a length of 4 and a width of 5 is: {0}", rectangleArea(4, 5));
      // Console.WriteLine("The area of a circle with a radius of 4 is: {0}", circleArea(4));
      // Console.WriteLine("The area of a triangle with a base of 10 and a height of 9 is: {0}", triangleArea(10, 9));
      double triangle = triangleArea(750, 500);
      double rectangle = rectangleArea(2500, 1500);
      double circle = circleArea(375 / 2) / 2;
      double totalArea = triangle + rectangle + circle;
      double totalCost = Math.Round(totalArea * 180, 2);
      Console.WriteLine($"The total cost to tile the Teotihuacan is {totalCost} mexian pesos.");
      // Is this math right? Oh well
    }

    public static double rectangleArea(double length, double width)
    {
      return length * width;
    }
    
    public static double circleArea(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    public static double triangleArea(double bottom, double height)
    {
      return .5 * bottom * height;
    }
  }
}
