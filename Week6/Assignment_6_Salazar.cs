/* Author : Alvaro Salazar
 * Date   : October 8, 2021
 * 
 * Assignment 6.1
 */
using System;

namespace Hypotenuse
{
    /* Specification:
     * Develop a C# console application that computes the hypotenuse of a 
     * right triangle. The computation of the hypotenuse of a right triangle 
     * is based on the Pythagorean Theorem: c2 = a2 + b2 and the hypotenuse, 
     * c ("long side") of the triangle can be computed with the formula 
     * the hypotenuse is equal to the square root of the side a squared 
     * plus side b squared. 
     * The application should take as many side pairs inputs as the user desires
     * and calculate each until the user enters a zero for both side one and side 
     * two (sentinel loop). You should use at least two (2) Math class methods. 
     * 
     * The output should look something like this:
     * 
     * enter length of first side: 3
     * enter length of second side: 4
     * The hypotenuse is 5
     * enter length of first side: 3.44
     * enter length of second side: 4.88
     * The hypotenuse is 5.97059461025449
     * enter length of first side: 10.55
     * enter length of second side: 33.0
     * The hypotenuse is 34.6453820876607
     * enter length of first side: 0
     * enter length of second side: 0
     * Press any key to continue . . .
     * 
     * Note in the first example with the entries of 3 and 4 that the hypotenuse 
     * is computed as 5. If you are not getting that answer (The hypotenuse is 5) 
     * with entries of 3 and 4 respectively, then you are not taking the inputs 
     * and converting them correctly. Remember that a ReadLine brings in characters 
     * but there are differences in how the conversion methods for character and
     * string values work. There is another way to convert a string number input 
     * to a numeric value type. You may have to do some research to come up with 
     * the right conversion method. Also note that type double values are used.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            double side_a = 0;
            double side_b = 0;

            // Prompt First Side - a
            Console.Write("enter length of first side: ");
            side_a = double.Parse(Console.ReadLine());

            // Prompt Second Side - b
            Console.Write("enter length of second side: ");
            side_b = double.Parse(Console.ReadLine());

            while ((side_a != 0) && (side_b != 0)) // Sentinel
            {
                double pow_a = 0;
                double pow_b = 0;
                
                pow_a = Math.Pow(side_a, 2); // side a to pow 2
                pow_b = Math.Pow(side_b, 2); // side b to pow 2

                // Compute Hypotenuse - Side c
                double side_c = Math.Sqrt(pow_a + pow_b);
                
                // Display output - Hypotenuse
                Console.Write($"The hypotenuse is {side_c}" );

                Console.WriteLine();

                // Prompt First Side - a
                Console.Write("enter length of first side: ");
                side_a = double.Parse(Console.ReadLine());

                // Prompt Second Side - b
                Console.Write("enter length of second side: ");
                side_b = double.Parse(Console.ReadLine());

            } // End while

            Console.Write("Press any key to continue...");
            Console.ReadKey();
              
        } // End main method

    } // End class

} // End namespace
