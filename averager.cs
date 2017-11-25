using System;
namespace Brennan
{
  class Program
  {
    
    static void Main()
    {
      //Prompt user for a userName
      Console.WriteLine("Please enter your name!");
      string userName = Console.ReadLine();//Save userName into a string variable
      Console.WriteLine("Welcome " + userName + "!");//Output a friendly message
      //Create variables to hold numberTotal and numbers
      double numberTotal = 0;//Total value
      int numbers = 0;//How many times a user enters in value
      try {
        while(true)
        {
          //Prompt user for an integer value
          Console.Write("Please enter a value or enter \"done\" to exit: ");
          string userInput = Console.ReadLine();
          if(userInput.ToLower() == "done") {
            break; //break out of the loop if user inputs "done"
          } else {
            double savedInput = double.Parse(userInput); //parse the userInput into a double
            numberTotal += savedInput; //numberTotal = numberTotal + savedInput
            numbers++; //increments by 1 everytime the while loop is run!!!! breakthrough
          }
        }
        //Find average by dividing numberTotal by how many times the user enters a value
        Console.WriteLine("The average of the values is: " + numberTotal / numbers);
      }
      //Catching the exception of no integers 
      catch(FormatException)
      {
        Console.WriteLine("This number is Not valid. Please try again!");
   
      }
    }
  }
}
