/*Purpose:To give a user the the average and the letter grade of an average of marks entered.
 * Input:markOne, markTwo, markThree (the marks must be between 0 to 100 and validated for invalid inputs)
 *Process:The user enters 3 marks then receives the average and the letter grade for the average.
 *Output: average, letterGrade
 *Author:
 *Last Modified Date: 3/6/2022
 *
 */



using System;

namespace CPSC1012_Lab4_MuhammadKhawaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables for the marks entered by user
             double markOne =0,
               markTwo=0,
                markThree=0;

            double sum = 0;
            double average= 0;


            sum = PromptForMark(markOne, markTwo, markThree);
           
           
            static double PromptForMark(double markOne, double markTwo, double markThree) {

         
                //verify user entererd allowable mark
                bool validInput = false;
                while (validInput == false) {
                    Console.Write("Enter first mark (between 0-100): ");
                    validInput = double.TryParse(Console.ReadLine(), out markOne);

                    if (validInput == true)
                    {
                        if (markOne >= 0 && markOne <= 100) {

                            Console.Write("Enter second mark (between 0-100): ");
                            validInput = double.TryParse(Console.ReadLine(), out markTwo);

                            if (validInput == true)
                            {
                                if (markTwo >= 0 && markTwo <= 100)
                                {
                                    Console.Write("Enter third mark (between 0-100): ");
                                    validInput = double.TryParse(Console.ReadLine(), out markThree);

                                    if (validInput == true)
                                    {
                                        if (markThree >= 0 && markThree <= 100)
                                        {
                                            Console.WriteLine("****************Student Grade Calculator****************");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input, try again.");
                                            validInput = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, try again.");
                                        validInput = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, try again.");
                                    validInput = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, try again.");
                                validInput = false;
                            }


                        }
                        else
                        {
                            Console.WriteLine("Invalid input, try again.");
                            validInput = false;
                        }
                    }
                    else {
                        Console.WriteLine("Invalid input, try again.");
                        validInput = false;
                    }

                   
                }
                double sum = markOne + markTwo + markThree;
                
                return sum;
                 
            }
            
            //calculate average of grades using the sum of the three grades
          
            
            double averageOfGrades = CalculateAverage(sum);
            // now run method to find average
            static double CalculateAverage(double sum) {

                double average = 0;
                
                average = sum / 3;

                return average;
            }

            Char studentCode = LetterGrade(averageOfGrades);

            static char LetterGrade(double averageOfGrades)
            {
                char gradeLetter = 'A';
                if (averageOfGrades >= 80)
                {
                    gradeLetter = 'A';
                }
                else if (averageOfGrades < 80 && averageOfGrades >= 65)
                {
                    gradeLetter = 'B';
                }
                else if (averageOfGrades < 65 && averageOfGrades >= 50)
                {
                    gradeLetter = 'C';
                }
                else if (averageOfGrades < 50 && averageOfGrades >= 40)
                {
                    gradeLetter = 'D';
                }
                else if (averageOfGrades < 40)
                {
                    gradeLetter = 'F';
                }
                else
                { Console.WriteLine("An error has occured."); }

                char studentCode = gradeLetter;
                return studentCode;
            }
            
            Console.WriteLine($"The average is { averageOfGrades.ToString("0.00")} %");
            Console.WriteLine($"Your grade letter is {studentCode}");


        }
    }
}
