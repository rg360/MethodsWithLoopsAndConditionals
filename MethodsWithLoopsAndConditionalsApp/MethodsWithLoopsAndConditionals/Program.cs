using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"+"\r\n");

            //Write a method that will print to the console all numbers 1000 through -1000.
            /*
            for (int i = -1000; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            */

            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            /*
            for (int i = 0; i < 1000; i+=3)
            {
                Console.WriteLine(i);
            }
            */
            //Write a method to accept two integers as parameters and check whether they are equal or not.

            /*
            Console.WriteLine("Enter value for X");
            var x = Console.ReadLine();

            Console.WriteLine("Enter value for Y");
            var y = Console.ReadLine();

            do
            {

                Console.WriteLine("Equal");
            } while (x == y);
            */

            //Write a method to check whether a given number is even or odd.
            
            for (int i = 0; i <= 1000; i++)
                
            {
                Console.WriteLine("Enter value for i");
                var i = Console.ReadLine();
                if (i % 2 != 0)
                {
                    Console.WriteLine($"value {i} is an ODD number");
                }
            }
            //Write a method to check whether a given number is positive or negative.



            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!


        }
    }
}
