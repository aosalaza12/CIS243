/* Author : Alvaro Salazar
 * Date   : October 22, 2021
 * Week 8 - Extra Credit Challenge  
 */
using System;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;

namespace ArraysUsage
{
    /* Specification: This program, Create a console program where you will 
     * implement variables that are needed for this program and will implement 
     * the code within Main. 
     * Create an array that stores 10 prices.
     * Prompt the user to enter the 10 values as currency.
     * Access the array elements and display a sum of the 10 values.
     * Display all of the entered values less than $5.00.
     * Calculate the average of the 10 values.
     * Display the average of the entered values and the entered values higher 
     * than the average. 
     * 
     * You should format your output to look something like the following: 
     * This will require some analysis of the problem before coding is accomplished. 
     * 
     * Enter price 1  1.11
     * 
     * Enter price 2  2.22 
     * 
     * Enter price 3  3.33 
     * 
     * Enter price 4  4.44 
     * 
     * Enter price 5  5.55 
     * 
     * Enter price 6  6.66 
     * 
     * Enter price 7  7.77 
     * 
     * Enter price 8  8.88 
     * 
     * Enter price 9  9.99 
     * 
     * Enter price 10  10.10  
     * 
     * The sum of the values entered is: $60.05
     * 
     * Prices less than $5.00:$1.11 $2.22 $3.33 $4.44
     * 
     * Prices higher than average $6.01$6.66 $7.77 $8.88 $9.99 $10.10 
     * 
     * Press any key to continue . . . 
     * 
     */
    class ArraysUsage
    {
        private const double V = 5.00; // constant

        static void Main(string[] args)
        {

            // fill price array
            double wsumprice    = 0;
            double wavg         = 0;
            
            // array fill price
            double[] warray_price = new double[10];

            // Dyanmic array for prices less than 5
            double[] wArrayless5 = new double[] { };

            // prompt prices and fill array warray_price
            for (int i = 0; i < 10; i++)
            {
                // read in values and assign them to the array
                Console.Write("Enter price " + (i + 1)+ " ");
                decimal wprice = Convert.ToDecimal(Console.ReadLine());
                warray_price[i] = (double)wprice;

                Console.WriteLine();

            } // end fill price array


            // Access the array elements and display a sum of the 10 values.
            // Other useful array methods, such as Min, Max, and Sum, can be
            // found in the System.Linq namespace:
            //

            wsumprice = warray_price.Sum(); // 
            wavg = wsumprice / warray_price.Length ; 


            Console.WriteLine($"The sum of the values entered is: {wsumprice:C}");
            Console.WriteLine();
            
            // prices less than 5 array

            double[] res = Array.FindAll(warray_price, ele => (ele <= V));

            Console.Write("Prices less than $5.00:");
            foreach (var i in res) Console.Write($" " + $"{i:C}");

            Console.WriteLine();
            Console.WriteLine();


            // Prices higher than average

            double[] avg = Array.FindAll(warray_price, ele => (ele >= wavg));

            Console.Write($"Prices higher than average {wavg:C} ");
            foreach (var i in avg) Console.Write($" " + $"{i:C}");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
