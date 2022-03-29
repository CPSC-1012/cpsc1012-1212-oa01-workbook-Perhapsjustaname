using System;

namespace CPSC1012_Lab5_MuhammadKhawaja
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sum = 0;
            int students = 5;
            int[] marks = new int[students];

            for (int i = 0; i < students; i++) {
                marks[i] = int.Parse(Console.ReadLine());
             
                sum =  sum +  marks[i];
            }

            for (int i = 0; i < students; i++)
            {

                Console.WriteLine(marks[i]);

            }
            Console.WriteLine(sum);


        }


        static public int PromptForPositiveNumber(string message)
        {
            int number = 0;
            bool validNumber = false;
            while (validNumber == false)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                    {
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! Number must be a positive non-zero number");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Input must be integer number");
                }
            }
            return number;
        }

    }

}





