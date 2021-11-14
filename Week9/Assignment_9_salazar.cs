/* Author : Alvaro Salazar
 * Date   : October 26, 2021
 * Assignment 9.1 
 */
using System;
using System.Globalization;

namespace Parallel_Arrays
{
    /* Specification: This program implements two parallel arrays in Main, one 
     * to hold double values called item_price and the other to hold strings
     * called item_name. Each array will hold 5 values. Use an initializer to 
     * fill the item_price array with the values 15.50, 50.99, 25.00, 115.49, 
     * 75.25. Use an initializer to fill the item_name array with the values
     * "Widget", "Thingy", "Ratchet", "Clanger", "Fracker". This application 
     * will use a method to change the corresponding prices for items based on a
     * price point and a multiplier which will require double value types. 
     * The inputs for the price and multiplier are input from the console.
     * 
     * Create two static methods, one called changePrices and one called printit.
     * When the changePrices method is called from Main you should pass the
     * item_price array by reference, the price point and price difference values input from the console to it. The changePrices method should loop through
     * the item price array and check the price point to determine the increase
     * in price for each price array element. The basic computation is:
     * 
     * if the current price is less than the price point then set the price equal
     * to the current price plus the current price times the price multiplier
     * In the printit method print the item name and the corresponding item price 
     * to the console as shown in the output example below.
     * 
     * The price for item Widget is $15.50
     * The price for item Thingy is $50.99
     * The price for item Ratchet is $25.00
     * The price for item Clanger is $115.49
     * The price for item Fracker is $75.25
     * 
     * Enter the price cutoff point (eg $15.00) $60.00
     * Enter the percentage price change (eg 0.25) 0.15
     * 
     * The price for item Widget is $17.83
     * The price for item Thingy is $58.64
     * The price for item Ratchet is $28.75
     * The price for item Clanger is $115.49
     * The price for item Fracker is $75.25
     * 
     * Press any key to continue . . .
     * 
    */

    class Parallel_Arrays
    {
        static void Main(string[] args)
        {
            double dprice_point = 0;
            string str_pricePoint;

            //t wo arrays of different types each initialized to 5 elements
            // int[] part_num = { 10, 20, 30, 40, 50 };


            double[] item_price = { 15.50, 50.99, 25.00, 115.49, 75.25 };
            string[] item_name = { "Widget", "Thingy", "Ratchet", "Clanger", "Fracker" };

            // Call pintit Method Before the changePrices Method
            printit(item_name, item_price  );
            Console.WriteLine();

            // Input from the console - price cutoff point 
            Console.WriteLine("Enter the price cutoff point (eg $15.00) ");
            str_pricePoint = Convert.ToString(Console.ReadLine());

            string input = str_pricePoint ;

            // conver string to double

            double.TryParse(input, NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out dprice_point );

            // Input from the console - percentaje price change

            Console.WriteLine("Enter the percentage price change (eg 0.25) ");
            double dprice_diff = Convert.ToDouble(Console.ReadLine());

            // Call changePrices Method

            changePrices(item_price, dprice_point, dprice_diff);

            Console.WriteLine();

            // Call pintit Method after the changePrices Method

            printit(item_name, item_price);

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();


        } // End Main Method

        // Display output 
        static void printit(string[] passed, double[] passed1)
        {
            for (int x = 0; x < passed.Length; x++)
            {
                Console.WriteLine("The price for item " + passed[x] + " is " + passed1[x].ToString("C") );

            } // end for

        } // End printit Method. 
        

        // changePrices Method.
        static void changePrices(double[] passed, double dprice_point, double dprice_diff)
        {

            for (int x = 0; x < passed.Length; x++)
            {
                if(passed[x] < dprice_point)// if item is < dprice_point
                {
                    decimal dec_price = (decimal)(passed[x] * (dprice_diff + 1));

                    // round to the nearest cent. 
                    passed[x] = (double)Math.Round(dec_price, 2, MidpointRounding.AwayFromZero);

                } // End if
                
            } // End for
                        
        } // End changePrices Method

    } // End class Parallel_Arrays

} // End namespace Parallel_Arrays
