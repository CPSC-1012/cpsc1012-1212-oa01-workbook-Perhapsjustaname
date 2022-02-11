/***

·//Purpose: To write a program which prints out a teaspoons to tablespoons table in increments entered by the user

·//Input: increment(positive number)

·//Output: tableSpoons, teaSpoons

·//Written by: Muhammad Khawaja

·//Written for: Sam Wu

·//Section A01

***/
using System;

namespace CPSC1012_Lab3_MuhammadKhawaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int increment = 0;
            bool incrementConfirmation;
            double teaSpoons = 0;
            double tableSpoons = 0;
            bool restartProgram = false;
           

            while (restartProgram == false)
            {

                //prompt for user input for increment
                Console.Clear();
                
                Console.WriteLine("**********Conversion Table**********");
                Console.Write("Please enter the increment to be used for your table(must be positive and (1-20)): ");
                //Increment Confirmation will be used to confirm a valid increment was entered

                incrementConfirmation = int.TryParse(Console.ReadLine(), out increment);
                
                
                
                if (incrementConfirmation)
                {
                   
                   

                    //confirm increment entered is between 1-20
                    if (increment >= 1 && increment <= 20)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Tea Spoons   Table Spoons");
                        Console.WriteLine("==========   ============");
                        teaSpoons = 1;
                       

                        while (teaSpoons <= 20)
                        {
                            tableSpoons = teaSpoons / 3;
                           
                            Console.WriteLine($"{teaSpoons}      {Math.Round(tableSpoons,2),10}");
                            Console.WriteLine();
                            teaSpoons = teaSpoons + increment;
                        }

                        Console.WriteLine("Would you like to run the program again?(Y-yes): ");
                        if (Console.ReadLine() == "Y")
                        { restartProgram = false; }
                        else { restartProgram = true; }
                        
                    }
                    else {
                        Console.WriteLine("Invalid increment. Press enter to continue.");
                        Console.ReadLine();
                        restartProgram = false;
                    }
                    
                }
                else {
                    Console.WriteLine("Invalid increment. Press enter to continue.");
                    Console.ReadLine();
                    restartProgram = false;
                }

            }
            }
    }
}
