using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("how to use TryParse to validate for numeric input from string");
            // prompt for a valid hockey player number between 1 and 99
            // repeat until valid number is entered



            int hockeyPlayernumber;
            bool validInput = false;
            Console.Write("Enter the hockey player number between 1-99: ");

            while (validInput == false)
            {
                validInput = int.TryParse(Console.ReadLine(), out hockeyPlayernumber);

                if (hockeyPlayernumber >= 1 && hockeyPlayernumber <= 99) { 

                if (validInput == true)
                {
                    Console.WriteLine($"Your hockey player number is: {hockeyPlayernumber}");
                }
                else
                {
                    Console.Write("Invalid input value, try again.: ");
                }
                }
                else
                {
                    validInput = false;
                    Console.Write("Invalid input value, try again.: ");
                } 
            }
        }
    }
}
