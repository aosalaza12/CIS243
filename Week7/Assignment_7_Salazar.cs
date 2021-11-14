/* Author : Alvaro Salazar
 * Date   : October 15, 2021
 * Assignment 7.1 
 */
using System;
using System.Security.Cryptography.X509Certificates;

namespace AverageRandom
{
    /* Specification:
     * You will need four variables: an integer value to hold a random value, 
     * a double value to hold an average, a double value to hold a total, and 
     * a double value to hold an input entry. 
     * Using a for loop that will call a getRandom method 20 times. In the loop 
     * you will pass a seed value to the getRandom method to use with the random 
     * generator and it will return a random value to be added to (accumulate) 
     * to the local integer variable in Main. In the getRandommethod you will 
     * generate a random value between 1 and 100  (see p241, section 7.9) and 
     * return that random value to Main. The random value will be generated in 
     * getRandom using a Random class object. 
     * Once the loop has completed the 20 method calls you will call a calculate
     * method which returns no value and to which you will pass the total of the
     * random values, the average variable by reference, and the literal value 
     * of 20. In the calculate method you will compute and average by dividing
     * the total of the random number passed in by the literal value 20 that was 
     * passed into the calculate method. 
     * After the calculate method executes you will display the average to the 
     * console. 
     * Following the writeline statement noted above, you will implement a second 
     * for loop that will process 5 iterations. Within this for loop you will 
     * prompt the user to enter a double value from the console and then assign 
     * that input to the double variable declared to hold the input entry. Also 
     * within the loop you will call an overload of the void calculate method 
     * and will pass two arguments:  the entry taken from the console and the 
     * variable to hold the total by reference. The overload of the void 
     * calculate method will receive the double entry value and the byref double
     * variable that will receive the total. In the overloaded calculate method 
     * you will add the value passed in to the total variable. 
     * After the overloaded calculate method executes you will display the total
     * to the console.
     * In summary:
     * You will have Main in which you will declare 4 variables, a loop that will
     * call a method that will return a random number, a call to a void calculate 
     * method which will take an integer random value variable, a byref average 
     * variable, a literal value of 20 as arguments and which will calculate an 
     * average, followed by a console writeline to display the average. This will
     * be followed by a loop that will execute 5 times and will prompt for and 
     * assign a double value to a double variable and then call an overload of 
     * the calculate method and pass the entered value and a byref total variable. 
     * In the overloaded calculate method you will accumulate the passed value 
     * into the total variable. After the loop you will display the total. 
     * 
     * The output might look similar to this: 
     * 
     * The average of the 20 random numbers is 71
     * 
     * Enter a double value 11.11
     * Enter a double value 22.22
     * Enter a double value 33.33
     * Enter a double value 44.44
     * Enter a double value 55.55
     * The total is 166.65
     * Press any key to continue . . . 
    */

    class AverageRandom
    {
        //public static method to get the random numbers
        public static int getRandom(int seed, ref int n)
        {
            Random rnd = new Random(seed); // new constructor Random
            
            n = rnd.Next(1, 101); // 1 <= n <= 100

            return n ;
        }

        //public static method to get the average
        // first overloaded calculate method
        // pass by value(total_rnd), pass by ref(avg) and pass by value(witer) 
        public static void calculate(int total_rnd, ref double avg, int witer)
        {
            avg = total_rnd / witer; // compute average
                       
        }

        //public static method to overload calculate method.
        // second overloaded calculate method
        // pass by value(winput_m), pass by ref(total_input)
        public static void calculate(double winput_m, ref double total_input)
        {
            total_input = total_input + winput_m; // compute Total Random Numbers

        }

        // Method Main
        static void Main(string[] args)
        {
            int total_rnd       = 0 ;
            int n               = 0 ;
            double avg          = 0 ;
            int witer           = 20;
            double winput           ;
            double total_input  = 0;
            int seedValue       = 1961;

            // Loop for 20 iterations
            for (int i = 1; i <= 20; i += 1)
            {
                /* get Random Number in every iteration.
                 * as the seed is the same, the random number will be the same
                 * for this case. 
                 */

                getRandom(seedValue, ref n);

                // calculate total Random numbers. 
                total_rnd = total_rnd  + n;

            }

            // compute average
             
            calculate(total_rnd, ref avg, witer);

            Console.WriteLine($"The average of the 20 random numbers is {avg}");
            Console.WriteLine();

            // Second loop - process 5 iterations

            for (int i = 1; i <= 5; i += 1)
            {
                Console.WriteLine("Enter a double value ");
                winput = Convert.ToDouble(Console.ReadLine());

                // calls the overloaded method calculated
                calculate(winput, ref total_input);
                             
            }

            // convert to decimal type
            decimal wtotal_input = (decimal)total_input;

            // show by console the total
            Console.WriteLine($"The total is {wtotal_input}");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
