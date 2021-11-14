/* Author : Alvaro Salazar
 * Date   : September 26, 2021
 */
using System;

namespace DisplayPatterns
{
    /* Specifications: This program displays the two (2) following patterns 
     * separately, one below the other. Use for loops (hint: nested) to generate
     * the patterns. All asterisks should be displayed by a single statement of
     * the form Console.Write("*"); which displays the asterisks leading up to 
     * the number value shown in the example. A statement of the form 
     * Console.WriteLine(); can be used to move to the next line. 
     * Note the sequence of each number in turn. Remember that this is two 
     * separate sets of loops which are used to generate these two patterns. 
     * You will need to deduce how the numbers are computed (they are the result
     * of a computation) and where that computation will be placed in the 
     * loop structures. 
     * You may not hardcode the displayed numbers into your loops.
     * Example: The two patterns should look similar to the following
     * 
     *   *2
     *   **4
     *   ***6
     *   ****8
     *   *****10
     *   ******12
     *   *******14
     *   ********16
     *   *********18
     *   **********20
     *
     *   **********20 
     *   *********18
     *   ********16
     *   *******14
     *   ******12
     *   *****10
     *   ****8
     *   ***6
     *   **4
     *   *2
     *  Press any key to continue . . .
     */

    public class DisplayPatterns
    {
        public static void Main(string[] args)
        {
            int y; // Variable for iteration and display "*"
            int x; // Variable for even numbers
            
            // loop through all even numbers from 2 to 20
            for (x = 2; x <= 20; x += 2)
            {

                y = x / 2; // Iterations for display "*"

                // for loop for pattern "*"
                for (int z = 1; z <= y; z += 1)
                    Console.Write("*");

                Console.WriteLine(x); // show results for the even number in
                                      // ascending order.

            } // end for the even number in ascending order.

            Console.WriteLine(); // move to the next line

            // loop through all even numbers from 20 to 2

            for (x = 20; x >= 2; x -= 2)
            {
                y = x / 2; // Iterations for display "*"

                // for loop for pattern "*"
                for (int z = 1; z <= y; z += 1)
                    Console.Write("*");

                Console.WriteLine(x); // show results for the even number
                                      // in descending order.

            } // end for the even number in descending order.

        } // end Main

    } // end class DisplayPatterns

} // end namespace Displaypatterns 
