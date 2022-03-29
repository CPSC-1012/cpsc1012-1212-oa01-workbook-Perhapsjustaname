using System;

namespace Testing23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mark,
                  count = 0;
            double sum = 0,
                average;

            Console.WriteLine(" enter marks between 0 and 100: ");

            mark = 0;
            while (mark >= 0 && mark <= 100) {
                mark = int.Parse(Console.ReadLine());

                if (mark >= 0 && mark <= 100)
                {
                    sum = sum + mark;
                    count = count + 1;
                }
            }    
            

             

            average = sum / count;
            Console.WriteLine("class average is "+average);

        }
    }
}

