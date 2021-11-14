/* Author : Alvaro Salazar
 * Date   : September 16, 2021
 */
using System;

namespace payrate
{
    class Payrate
    {
        /* Specification: This program compute the Gross pay and Net pay.
        * 
        * Prompt the user to enter values for hourly rate and hours worked.
        * Compute the gross weekly pay calculated as hours times rate for the first
        * 40 hours times 1.5 times the rate for any hours over the first 40 hours.
        * Compute the net pay as the gross pay minus withholding; withholding is 
        * calculated as: 
        * 28 percent of gross pay if gross pay is greater than $1000
        * 21 percent of gross pay if gross pay is greater than $600 and
        * less than or equal to $1000
        * 10 percent of gross pay if gross pay is less than or equal to $600
        * 
        * Display the input/output as something like the following: 
        * Example:
        * 
        * Enter hourly pay rate 30.00
        * 
        * Enter hours worked 50
        *
        * Gross pay is $1650 and net pay is $1188
        */
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //declare the local val1 and val2 integer variables
            double hwage = 0;       // Variable for Hourly rate
            double hwage_ovt = 0;   // Variable for Hourly rate Over Time
            int nhwork   = 0;       // Variable for number of hours worked
            double gpay = 0;        // Variable for gross weekly
            int nhours_ovt = 0;     // Varialbe for hours over 40
            double netpay = 0;      // Variable for net pay
            double wdiscounts = 0;  // Variable for withholding

            //prompt the user for input of two integers

            // Request hourly wage
            Console.Write("Enter hourly pay rate ");

            // Convert from the string input to integer
            hwage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            // Request hours worked
            Console.Write("Enter hours worked ");

            // Convert from the string input to integer
            nhwork = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Hourly wage Over time
            hwage_ovt = hwage * 1.5;

            // Compute the gross weekly pay

            if (nhwork <= 40) // Normal hourly
            {
                gpay = hwage * nhwork; // Gross pay
            }
            else // Hours Over Time
            {
                // Compute the number of hours over 40.
                nhours_ovt = nhwork - 40;

                gpay = (hwage * 40) + (hwage_ovt * nhours_ovt); // Gross pay Over
            } // end if

            // Compute Withholding

            if (gpay > 1000)
            {
                wdiscounts = gpay * 0.28;
            }
            else if (gpay > 600 && gpay <= 100)
            {
                wdiscounts = gpay * 0.21;
            }
            else if (gpay <= 600)
            {
                wdiscounts = gpay * 0.10;
            }

            // Compute Net Pay

            netpay = gpay - wdiscounts;

            // print the results to console
            Console.WriteLine("Gross pay is $" + gpay + " and net pay is $" + netpay);
                        
        }
    }
}
