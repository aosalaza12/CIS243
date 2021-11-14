/* Author : Alvaro Salazar
 * Date   : October 15, 2021
 * Week 7 - Extra Credit Challenge 
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace RandomNumberLowUpper
{
    class RandomNumberLowUpper
    {
        /* Specification: this program that will generate a random number based
         * on lower and upper range inputs.
         * 
         * The program will take inputs for a range of integer numbers, a low 
         * end of the range and a high end of the range. These two integer 
         * numbers will be used to generate a random number that will be displayed. 
         * The program will consist of Main and three void methods. 
         * The first method will request the low number for the range and the 
         * high number in the range. It will then pass the two range numbers to
         * a second method.
         * The second method will take the two numbers passed to it and will 
         * generate a random number within the range. It will then pass the two 
         * range numbers and the random number to the third method. 
         * The third method will take the three numbers passed to it and display 
         * then to the console in the format indicated in the sample output below. 
         * Main will only have one line of code which will call the first method. 
         * The first method will call the second method and the second method 
         * will call the third. 
         * 
         * You should format your output to look something like the following: 
         * 
         * Enter the low integer range number: 1 
         * 
         * Enter the high integer range number: 1000 
         * 
         * random number from range 1 and 1000 is 710 
         * 
         * Press any key to continue . . . 
         *   
         */


        // Static void first method. Prompt low and high numbers range.
        static void PromptRange()
        {
            int wlowrange  ;
            int whighrange ;

            // Prompt low number for the range
            Console.Write("Enter the low integer range number: ");
            wlowrange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Prompt high number in the range.
            Console.Write("Enter the high integer range number: ");
            whighrange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // call second static method
            getRandom( wlowrange, whighrange);

        }

        // Static void second method. get Random number betwwen range. 
        static void getRandom(int wlowrange, int  whighrange)
        {
            int n;
            int whighrange1 = whighrange + 1;
            

            Random rnd = new Random(); // new constructor Random

            // get random integers wlowrange to whighrange
            // example: wlowrange = 1
            //          whigrange = 1000
            //          rnd.Next(1, 1001) 1 <= n <= 1000

            n = rnd.Next(wlowrange , whighrange1); // wlowrange <= n <= whighrange

            // call the third method, passing by value low and high range and
            // random number.
            displayConsole(wlowrange, whighrange, n);

        }

        // static void method, display to the console the results.
        static void displayConsole(int wlowrange, int whighrange, int n)
        {

            Console.Write($"random number from range {wlowrange} and {whighrange } is {n} ");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Press any key to continue...");

            Console.ReadKey();

        }

        // Main Method.

        static void Main(string[] args)
        {
            // calls first method
            PromptRange();
                                    
        }
    }
}
