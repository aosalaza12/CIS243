/* Author : Alvaro Salazar
 * Date   : September 22, 2021
 * Assignment 4.1
 */
using System;

namespace GrossPay
{
    /* Specification: This program determine the gross pay for each of three 
     * employees. The company pays straight time for the first 40 hours worked 
     * by each employee and time and a half for all hours worked in excess of 
     * 40 hours. You are given a list of the three employees of the company, 
     * the number of hours each employee worked last week, and the hourly 
     * rate of each employee. Your application should input this information 
     * for each employee and should determine and display the employee’s 
     * gross pay. Use the Console class’s ReadLine method to input the data. 
     * Use a while loop to implement the inputs and calculations.
     * 
     * Example:
     * Enter hourly rate: 15.00
     * Enter hours worked: 40
     * Pay for employee is $600.00
     * 
     * Enter hourly rate: 15.00
     * Enter hours worked: 45
     * Pay for employee is $712.50
     * 
     * Enter hourly rate: 15.00
     * Enter hours worked: 35
     * Pay for employee is $525.00
     * 
     * Press any key to continue . . 
     */

    public class GrossPay
    {
        public static void Main(string[] args)
        {
            int n = 1;              // initialize count to 1
            Decimal wgrosspay = 0;  // Variable for Gross Pay
            int nhours_ovt    = 0;  // Varialbe for hours over 40
            double hrate_ovt  = 0;  // Variable for Hourly rate Over Time

            while (n <= 3)          //  3 cycle iterations
            {
                // Prompt Hourly rate 
                Console.WriteLine("Enter hourly rate: ");
                double hrate = Convert.ToDouble(Console.ReadLine());

                // Prompt Hours worked 
                Console.WriteLine("Enter hours worked: ");
                int hwork = Convert.ToInt32(Console.ReadLine());

                // compute Gross pay

                // Selection stament for Over Time
                if (hwork <= 40)
                {
                    wgrosspay = (decimal)(hwork * hrate);
                }
                else // Compute Hours Over Time
                {
                    nhours_ovt = hwork - 40; // Hours Over Time
                    hrate_ovt = hrate * 1.5; // Hourly rate Over time
                    
                    // Calculate Gross Pay
                    wgrosspay = (decimal)((hrate * 40) + (hrate_ovt * nhours_ovt));
                }

                // display the employee’s gross pay
                Console.WriteLine($"Pay for employee is ${wgrosspay:F2}");

                Console.WriteLine();
                ++n; // Increment in 1 the count
            }
        }
    }
}
