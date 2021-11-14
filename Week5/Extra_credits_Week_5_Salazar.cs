/* Author : Alvaro Salazar
 * Date   : September 28, 2021
 * Extra Credits - Week 5
 */
using System;

namespace fundraiser
{
    /* Specifications: 
     * Create a console program where you will implement variables that are 
     * needed for this program and will implement the code entirely within Main.
     * 1. Prompt the user for contributions. It should first ask for the 
     *    contributor's grade.
     * 2. Then it should ask how much the student is contributing.
     * 3. These prompts should be placed inside of a loop so that the program 
     *    will continue to ask for contributions until a value of 999 is entered
     *    for the contributor's grade.
     * 4. Once that value is entered, the program should calculate the average 
     *    value of the contributions.
     * 5. Display the results, with a congratulatory message for the class
     *    which collected the largest amount.
     * 6. Use a Boolean variable to control the while loop.
     * 7. Use a switch statement to help get the input into the proper variables.
     * 8. Place the switch statement within the while loop and use the Boolean 
     *    variable to control the loop and set its value to false when the 
     *    sentinel value (999) is detected.
     * 9. When calculating the averages you will need a selection statement for
     *    each grade contribution to either compute the individual grade 
     *    contribution average or to set it to zero if there were no 
     *    contributions for that grade.
     *    
     *Example: You should format your output to look like the following:
     * 
     * Please enter the grade of the contributor (6, 7, or 8)
     * (enter 999 to quit):
     * 6
     * Please enter the amount of the contribution:
     * 10.99
     * Please enter the grade of the contributor (6, 7, or 8)
     * (enter 999 to quit):
     * 6
     * Please enter the amount of the contribution:
     * 100.50
     * Please enter the grade of the contributor (6, 7, or 8)
     * (enter 999 to quit):
     * 7
     * Please enter the amount of the contribution:
     * 75.00
     * Please enter the grade of the contributor (6, 7, or 8)
     * (enter 999 to quit):
     * 7
     * Please enter the amount of the contribution:
     * 80
     * Please enter the grade of the contributor (6, 7, or 8)
     * (enter 999 to quit):
     * 8
     * Please enter the amount of the contribution:
     * 44.50
     * Please enter the grade of the contributor (6, 7, or 8)
     * (enter 999 to quit):
     * 8
     * Please enter the amount of the contribution:
     * 77.77
     * Please enter the grade of the contributor (6, 7, or 8)
     * (enter 999 to quit):
     * 999
     * Grade Level    # of Contrib    Total Amount    Average
     * 6th Grade              2            $111.49     $55.75
     * 7th Grade              2            $155.00     $77.50
     * 8th Grade              2            $122.27     $61.14
     * 
     * Congratulations 7th graders!
     * Press any key to continue . . .
     */
    public class Fundraiser
    {
        public static void Main(string[] args)
        {
            int wgrade;
            int wcount6     = 0;
            int wcount7     = 0;
            int wcount8     = 0;
            double wcontr;
            double wtotalc6 = 0;
            double wtotalc7 = 0;
            double wtotalc8 = 0;
            Boolean wcond = true;

            string wsgrade6 = "6th Grade";
            string wsgrade7 = "7th Grade";
            string wsgrade8 = "8th Grade";

            // Prompt first time
            Console.WriteLine("Please enter the grade of the contributor (6, 7, or 8)\n"
            + "(enter 999 to quit):");
            wgrade = Convert.ToInt32(Console.ReadLine());

            while (wcond) // Sentinel-controlled iteration
            {
                // prompt
                Console.WriteLine("Please enter the amount of the contribution:");
                wcontr = Convert.ToDouble(Console.ReadLine());

                // compute a Fundraiser
                switch (wgrade) // Jump statements
                {
                    case 6:
                        wtotalc6 = wtotalc6 + wcontr; // add conttribution grade 6
                        ++wcount6;                    // add counter grade 6
                        break;

                    case 7:
                        wtotalc7 = wtotalc7 + wcontr; // add contribution grade 7
                        ++wcount7;                    // add counter grade 7 
                        break;

                    case 8:
                        wtotalc8 = wtotalc8 + wcontr; // add contribution grade 8
                        ++wcount8;                    // add counter grade 8
                        break;

                } // end switch

                // Prompt the grade 
                Console.WriteLine("Please enter the grade of the contributor (6, 7, or 8)\n"
                + "(enter 999 to quit):");
                wgrade = Convert.ToInt32(Console.ReadLine());

                // check exit
                if (wgrade == 999)
                {
                    wcond = false;
                }

            } // end while

            // Compute average and largest amount.
            decimal wavg6 = (decimal) wtotalc6 / wcount6;
            decimal wavg7 = (decimal) wtotalc7 / wcount7;
            decimal wavg8 = (decimal) wtotalc8 / wcount8;


            double wlargest = wtotalc6; // assume grade 6 is the largest amount
            string wcongrats = "6th";

            // largest amount
            if (wtotalc7 > wlargest)
            {
                wlargest = wtotalc7;
                wcongrats = "7th";
            }
            else if (wtotalc8 > wlargest)
            {
                wlargest = wtotalc8;
                wcongrats = "8th";
            }

            // Display results and congrats.

            // Display Headers
            Console.WriteLine("Grade Level   # of Contrib    Total Amount   Average");

            // Display results
            Console.WriteLine($"{ wsgrade6,9} { wcount6,11} { wtotalc6,20:C2} { wavg6,9:C}");
            Console.WriteLine($"{ wsgrade7,9} { wcount7,11} { wtotalc7,20:C2} { wavg7,9:C}");
            Console.WriteLine($"{ wsgrade8,9} { wcount8,11} { wtotalc8,20:C2} { wavg8,9:C}");

            Console.WriteLine();

            // Display congrats.
            Console.WriteLine("Congratulations " + wcongrats + " graders!");

        } // end Main

    } // end class Fundraise

} // end namespace fundraise
