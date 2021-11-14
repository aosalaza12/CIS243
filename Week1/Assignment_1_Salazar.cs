/* Author : Alvaro Salazar
 * Date   : August 30, 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assignment_1_Salazar
{
    /* Specification: This program reads three integers, adds all three together, 
    * computes an average of the three entries, and computes any remainder of the 
    * integer division.
    * Example:
    * Enter an integer score 4
    * Enter an integer score 5
    * Enter an integer score 8
    * The average of 4, 5, 8 is 5 with a remainder of 2
    * 
    * return : None
    * Parameters: None
    *  
    */
    class Assignment_1_Salazar
    {
        static void Main(string[] args)
        {
            //declare variables
            int iter    = 3; 
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int sum     = 0;
            int module  = 0;
            Double avg  = 0;

            // Read Number 1
            Console.Write("Enter an Integer score ");
            number1 = Convert.ToInt32(Console.ReadLine());
            // Read Number 2
            Console.Write("Enter an Integer score ");
            number2 = Convert.ToInt32(Console.ReadLine());
            // Read Number 3
            Console.Write("Enter an Integer score ");
            number3 = Convert.ToInt32(Console.ReadLine());

            // sum the 3 integers
            sum = number1 + number2 + number3;

            // Computes the average
            avg = sum / iter;

            // Compute any remainder
            module = sum % iter;

            // Display the output

           Console.WriteLine("The average of " + number1 + ", " + number2 + ", "
               + number3 + " is " + avg + " with a remainder of " + module);

            Console.WriteLine();
        }
    }
}
