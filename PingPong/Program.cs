using System;
using PingPong.Models;

namespace PingPong
{
  class Program
  {
    static void Main()
    {
    //   Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    //   Console.WriteLine("Welcome to the Shape Tracker app!");
    //   Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
    //   Console.WriteLine("Please enter a number:");
    //   string stringNumber1 = Console.ReadLine();  
    //   Console.WriteLine("Enter another number:");
    //   string stringNumber2 = Console.ReadLine();  
    //   Console.WriteLine("Enter a third number:");
    //   string stringNumber3 = Console.ReadLine();  
      
    //   try
    //   {
    //     // properties from the ConsoleColor class
    //     Console.BackgroundColor = ConsoleColor.White;
    //     Console.ForegroundColor = ConsoleColor.Black;
    //     int length1 = Convert.ToInt32(stringNumber1);  
    //     int length2 = Convert.ToInt32(stringNumber2);  
    //     int length3 = Convert.ToInt32(stringNumber3);  
    //     Triangle tri = new Triangle(length1, length2, length3);
    //     ConfirmOrEditTriangle(tri);
    //   }
    //   catch (Exception ex)
    //   {
    //     Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    //     Console.WriteLine("ERROR: {0}", ex.Message);
    //     Console.WriteLine("Source = {0}", ex.Source);
    //     Console.WriteLine("StackTrace = {0}", ex.StackTrace);
    //     Console.WriteLine("TargetSite = {0}", ex.TargetSite);
    //     Console.WriteLine("ERROR: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
    //     Console.WriteLine("Please try again...");
    //     Main();
    //   }
    // }

    // static void ConfirmOrEditTriangle(Triangle tri)
    // {
    //   Console.WriteLine("Please confirm that you entered in your triangle correctly:");
    //   Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
    //   Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
    //   Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
    //   Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
    //   string userInput = Console.ReadLine();  
      
    //   if (userInput == "yes")
    //   {
    //     CheckTriangleType(tri);
    //   }
    //   else
    //   {
    //     Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
    //     Console.WriteLine("Please enter a number:");
    //     string stringNumber1 = Console.ReadLine();  
    //     Console.WriteLine("Enter another number:");
    //     string stringNumber2 = Console.ReadLine();  
    //     Console.WriteLine("Enter a third number:");
    //     string stringNumber3 = Console.ReadLine();  
    //     tri.Side1 = int.Parse(stringNumber1);  
    //     tri.Side2 = int.Parse(stringNumber2);  
    //     tri.SetSide3(int.Parse(stringNumber3)); 
    //     ConfirmOrEditTriangle(tri);
    //   }
    // }

    // static void CheckTriangleType(Triangle tri)
    // {
    //   string result = tri.CheckType();
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("Your result is: " + result + ".");
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("What's next?");
    //   Console.WriteLine("Would you like to check a new triangle (new)?");
    //   Console.WriteLine("Please enter 'new' to check the type of a new triangle. To exit, enter any key.");
    //   string userResponse = Console.ReadLine().ToLower(); 
    //   if (userResponse == "new")
    //   {
    //     Main();
    //   }
    //   else
    //   {
    //     Console.WriteLine("Goodbye!");
    //   }
    }
  }
}