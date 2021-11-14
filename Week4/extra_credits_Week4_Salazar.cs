/* Author : Alvaro Salazar
 * Date   : September 22, 2021
 * Extra Credit Week 4
 */
using System;

namespace Paysalesman
{
    /* Specification: 
     * Create a console application, no user-defined class is necessary for 
     * this program, all code is to be implemented in Main. 
     * Declare variables that will hold values for double sales, 
     * integer salesman number, double employee pay and declare 
     * three type double constants for COMMRATE1, COMMRATE2 and COMMRATE3. 
     * Initialize all of your variables when declared and set values of 0.10, 
     * 0.20 and 0.30 for COMMRATE1, 2 and 3 respectively.
     * Create a sentinel while loop to take inputs for employee sales until 
     * the user enters a zero. The sentinel should be based on the entry of the
     * integer salesman number.
     * In the while loop:
     *  prompt the user for salesman number entry: "enter sales # for employee "
     *  convert the keyboard entry to integer and assignment to salesman number 
     *  if the salesman number for the entry was a zero write "Ending program" 
     *  to the console and break. 
     *  prompt the user to "enter sales amount for employee 1" 
     *  convert the entry to double and assign it to sales 
     *  evaluate the following criteria: 
     *      if sales is greater than 3000 then set the employee pay to zero and
     *      write "Invalid sales entry" to the console because no sale 
     *      greater than 3000 should be enteredelse if sales 
     *      greater than or equal to 500 and sales less than or equal to 1000 
     *      then set employee pay equal to sales times COMMRATE1else 
     *      if sales greater than 1000 and sales less than or equal to 2000 
     *      then set employee pay equal to sales times COMMRATE2else 
     *      if sales greater than 2000 and sales less than or equal to 3000 
     *      then set employee pay equal to sales times COMMRATE3else set 
     *      employee pay equal to sales. 
     *      
     * write the salesman pay to the console, designating the salesman number 
     * you have computed pay for; for example: "The pay for salesman #33 is 158" 
     * The input and output would look like this:
     * 
     * Example:
     * 
     * enter sales # for employee 1
     * enter sales amount for employee 1 2000
     * The pay for salesman #1 is 400
     * enter sales # for employee 2
     * enter sales amount for employee 2 3500
     * Invalid sales entry
     * The pay for salesman #2 is 0
     * enter sales # for employee 2
     * enter sales amount for employee 2 3000
     * The pay for salesman #2 is 900
     * enter sales # for employee 33
     * enter sales amount for employee 33 1580
     * The pay for salesman #33 is 316
     * enter sales # for employee 0 
     * Ending program
     * Press any key to continue . . ..
     */

    public class Paysalesman
    {
        public static void Main(string[] args)
        {
            /* declare variables double sales, employee pay, 
             * declare integer salesman number.
             * declare constant double COMMRATE1, COMMRATE2, COMMRATE3 setting 
             * them to 0.10, 0.20, 0.30 respectively.
             */

            double sales   = 0;
            double wemp_pay = 0;
            int wsal_num;    
            const double COMMRATE1 = 0.10;
            const double COMMRATE2 = 0.20;
            const double COMMRATE3 = 0.30;

            /*
            From the console display "enter sales # for employee ", this is the
            sentinel for while loop. 
            */
            Console.Write("enter sales # for employee ");
            wsal_num = Convert.ToInt32(Console.ReadLine());

            //while wsal_num is not equal to 0

            while (wsal_num != 0)          
            {
                // Prompt  
                Console.WriteLine("enter sales amount for employee " + wsal_num);
                sales = Convert.ToDouble(Console.ReadLine());

                // Compute pay - Nested if...else Statements
                if (sales > 3000)
                {
                    wemp_pay = 0;
                    Console.WriteLine("Invalid sales entry");
                }
                else if (sales >= 500 && sales <= 1000)
                {
                    wemp_pay = sales * Convert.ToDouble(COMMRATE1);
                }
                else if(sales > 1000 && sales <= 2000)
                {
                    wemp_pay = sales * Convert.ToDouble(COMMRATE2);
                }
                else if(sales > 2000 && sales <= 3000)
                {
                    wemp_pay = sales * Convert.ToDouble(COMMRATE3);
                }
                
                Console.WriteLine("The pay for salesman #" + wsal_num
                        + " is " + wemp_pay );
                
                Console.Write("enter sales # for employee ");
                wsal_num = Convert.ToInt32(Console.ReadLine());

            } // End while

            Console.WriteLine("Ending program");
        }
    }
}
