/* Author : Alvaro Salazar
 * Date   : November 4, 2021
 * Week 10 - Extra Credit Challenge 
 */

using System;
using System.Net.Mail;

namespace StringArray_2
{
    /* Specification:
     * Use the following string array declaration:
     * 
     * string[] compositeString = { "4for", "2is the", "3week 10 challenge assignment",
     * "1This assignment", "5CIS243" };
     * 
     * Note that each string in the string array has a different length and each 
     * has a number as the first character in the array.
     * 
     * The number at the beginning of each string indicates the numeric order that
     * the strings should be in. Note that in the output below the order numbers 
     * are not displayed.
     * Construct the loops, comparisons, boolean conditionals and any other variables 
     * or arrays that will extract each string in the array and arrange the separate 
     * strings into a single string which when displayed will produce the output 
     * shown below.
     * 
     * You should format your output to look exactly like the following:
     * 
     * This assignment is the week 10 challenge assignment for CIS243
     * Press any key to continue . . .
     * 
     */

    class StringArray_2
    {
        static void Main(string[] args)
        {
            // String array declaration
            string[] compositeString = { "4for", "2is the", "3week 10 challenge assignment",
                                         "1This assignment", "5CIS243" };
                                                            
            // Void Method for parse to create a single string.

            string scompletet = null;
            parceString(compositeString, ref scompletet);

            // Display output

            Console.WriteLine(scompletet);
            Console.Write("Press any key to continue...");
            Console.ReadKey();


        } // End Main

        static void parceString(string[] originalString, ref string ssingle)
        {

            // Sort the entire array using the default comparer.
            Array.Sort(originalString);

            // iterates the already sorted string array, to concatenate the
            // array into a single string. 
            foreach (string value in originalString)
            {
                var scomplete = value.Substring(1) + " ";
                ssingle += scomplete;

            } // End foreach

        } // End parceString

    } // End class StringArray_2

} // End namespace StringArray_2
