/* Author : Alvaro Salazar
 * Date   : October 20, 2021
 * Assignment 8.1 
 */

using System;
using System.Data;

class Arrays
{
    /* Specification: This console application implements an int array.
     * 
     * Use 2 'for' loops, the first to fill the array using the Random class to
     * generate random integers (see p241, section 7.9) using the next method of
     * the Random class and a second for loop to iterate through the filled 
     * array and print the values entered into the array by the random number 
     * generator. Use the array’s length variable to stay within the array 
     * bounds for both loops.
     * 
     * Possible output might look like this:
     * 
     * The array value is 488
     * The array value is 402
     * The array value is 237
     * The array value is 48
     * The array value is 390
     * The array value is 186
     * The array value is 425
     * The array value is 342
     * The array value is 477
     * The array value is 319
     * Press any key to continue . . .
     * 
     */

    static void Main()
    {

        // implicitly typed local inference for randomNumbers variable.
        var randomNumbers = new Random(); // random-number generator
        
        var  array = new int[10]; // Here, the compiler infers that array's type
                                  // is int[], because the compiler can determine
                                  // the type from expresion "new int[10]"

        // Fill the array - array[] - using the Random class to generate random
        // integers

        for (var rnd = 0; rnd < array.Length ; ++rnd)
        {
            var n = randomNumbers.Next(0, 1000);// Here, the compiler infers that
                                                // n's type is int, because the
                                                // compiler can determine the type
                                                // from expresion
                                                // "randomNumbers.Next(0, 1000)"

            array[rnd] = n;
        }


        // output each array element's value
        // print the values entered into the array by the random number generator

        for (var i = 0; i < array.Length; ++i)
        {
            Console.WriteLine($"The array value is {array[i]}");
        }

        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
}
