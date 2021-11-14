/* Author : Alvaro Salazar
 * Date   : November 4, 2021
 * Assignment 10.1 
 */

using System;

namespace StringArrays
{
    /* Specification: 
     * Develop a C# console application that implements three arrays; a string 
     * array initialized with exactly the following five data items { "Widget 15.50",
     * "Thingy 50.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" }, a string
     * array to hold the five part names to be parsed from the previously detailed
     * string array, an array of five double value prices to be parsed from the 
     * previously mentioned array. 
     * 
     * Create a void method that will accept as arguments the two arrays of 
     * strings and the array of doubles when called from Main. In the method 
     * you will access the five members of the first string array mentioned above 
     * and you will parse out the name portion of each string element (first 7 bytes), 
     * assigning the string value to the corresponding element in the array of names. 
     * In the method you will also parse out the numeric portion of each string 
     * and assign it to the corresponding element of the price array. The parsing 
     * should be done using the string method SubString.
     * 
     * In Main, after calling the parsing method you will display the elements 
     * of both the array of names and the array of prices side-by-side (do not 
     * display the array from which you parsed the data items). 
     * 
     * The output should look something like this:
     * 
     * Widget $15.50
     * Thingy $50.99
     * Ratchet $25.00
     * Clanger $115.49
     * Fracker $75.25
     * Press any key to continue . . .
     * 
     */

    class StringArrays
    {
        static void Main(string[] args)
        {
            // String array Data Items
            string[] stringsDataItems = { "Widget 15.50", "Thingy 50.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" };

            // String array name portion
            string[] stringNames = new string[5];

            // double array price portion
            double[] ditem_price = new  double[5];

            // Void Method for parse to create name and price separatly 
            parceNamesPrices(stringsDataItems, stringNames, ditem_price );


            //  display the elements of both the array of names and the array
            //  of prices side-by-side
            for (int i = 0; i < stringsDataItems.Length;  i++)
            {
                Console.WriteLine($"{stringNames[i]} {ditem_price[i]:C}");

            } // End for

            Console.Write("Press any key to continue...");
            Console.ReadKey();


        } // End Main

        static void parceNamesPrices(string[] originalString, string[] sconvert, double[] dprice)
        {
            // External Index for string array sconvert and double array dprice
            int i = 0;

            foreach (var data in originalString)
            {
                // name portion
                string spart1 = data.Substring(0, 7);

                // price portion
                string spart2 = data.Substring(7);
                
                // parse name portion to string array sconvert
                sconvert[i] = spart1;

                // parse price portion to double array dprice
                dprice[i] = Convert.ToDouble(spart2);

                // increases the index
                ++i;

            } // End foreach

         } // End changePrices Method

    } // End class StringArrays

} // End namespace StringArrays
