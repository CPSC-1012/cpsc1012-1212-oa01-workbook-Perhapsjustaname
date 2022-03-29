using System;

namespace UsefulCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array =   GenerateNumbers(1, 50, 7);

            DisplayNumbers(array);





        }
            //Generate random array
            static int[] GenerateNumbers(int min, int max, int count)
            {

                int[] array = new int[count];

                Random rand = new Random();

                for (int i = 0; i < count; i++)
                {
                //generate a random number between min and max
                //add the number only if number doestnt already exist in it
                //hint: call the duplicate checking method

                int randomNumber = rand.Next(min, max+1);
                //
                if (IsDuplicateNumber(randomNumber, array)==false)
                {
                    
                    array[i] = randomNumber;
                    i++;
                }
                
                 
                }

                //sort from smallest to largest
                //Hint: the array class has a static class level method for sorting
                Array.Sort(array);

                return array;
            }
        //look for duplicate numbers in the array
        static bool IsDuplicateNumber(int number, int[] array) {

            bool isDuplicate = false;
            //set isduplicate true if number is in array
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == number) { 
                isDuplicate = true;
                    i = array.Length; //exit loop
                }
            }


            return isDuplicate;
            
        }
            

            
            //display the array
            static void DisplayNumbers(int[] array)
            {

                Console.WriteLine("The list: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");

                }
            }
            
            


            
            //verify a positive number
            static int PromptForPositiveNumber(string message)
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


            
        
    






