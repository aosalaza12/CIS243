/* Author : Alvaro Salazar
 * Date   : October 8, 2021
 * Extra Credits - Week 6
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Week_6_Extra_Credits_Salazar
{
    /* Specifications:
     * This program compute the average of 4 separate weeks of average weekly 
     * temperatures for any given month.
     * 
     * Create a console program where you will implement variables that are 
     * needed for this program and will implement the code within Main and any 
     * static methods that are called. 
     * You will need variables for temperature, minimum temperature, maximum 
     * temperature, average temperature, total of temperatures and a count variable. 
     * 
     * Use a loop to call a static void calculate method four times, 
     * passing temperature, minimum temperature, maximum temperature, 
     * average temperature and total temperature by reference 
     * and pass count by value.
     * 
     * In the calculate method ask the user for a single temperature entry, 
     * add it to the total, determine the minimum and maximum temperature for 
     * the current call to the method and compute the current average. 
     * 
     * When the loop in Main has taken all four entries and done the calculations
     * call a static void display method to display the output for the min, max
     * and average temperature for the four entries. You will pass the min temp,
     * max temp and average temp.
     * 
     * You should format your output to look something like the following:
     * 
     * Please enter the average temperature for week 1 of the month: 11 
     * 
     * Please enter the average temperature for week 2 of the month: 22 
     * 
     * Please enter the average temperature for week 3 of the month: 33 
     * 
     * Please enter the average temperature for week 4 of the month: 44 
     * 
     * The lowest temperature for the month was: 11 degrees. 
     * 
     * The highest temperature for the month was: 44 degrees. 
     * 
     * The average temperature for the month was: 27.5 degrees. 
     * 
     * Press any key to continue . . .
     * 
     *  
     */
    class AvgTemperatures
    {
        static void Main(string[] args)
        {
            int temp        = 0;
            int min_temp    = 0;
            int max_temp    = 0;
            double avg_temp = 0;
            double total_temp  = 0;
            // int n_times     = 0;
            // int i;
            
            //


            for (int i = 1; i <= 4; i += 1)
            {
                
                calculate(ref temp, ref min_temp, ref max_temp, ref avg_temp, ref total_temp, i);
            }
            

            display(min_temp, max_temp, avg_temp );


        }

        static void calculate(ref int temp, ref int min_temp, ref int max_temp, ref double avg_temp, ref double total_temp, int i)
        {
            Console.WriteLine("Please enter the average temperature for week " + i + " of the month: ");
            temp = Convert.ToInt32(Console.ReadLine());

            total_temp = total_temp + temp;

            if (i == 1 || max_temp < temp )
            {
                max_temp = temp ;
            }

            if (i == 1 || min_temp > temp )
            {
                min_temp = temp ;
            }

            avg_temp = total_temp / i;

        }

        static void display(int min_temp, int max_temp, double avg_temp)
        {
            Console.WriteLine($"The lowest temperature for the month was: {min_temp} degrees.");
            Console.WriteLine();

            Console.WriteLine($"The highest temperature for the month was: {max_temp} degrees. ");
            Console.WriteLine();

            Console.WriteLine($"The average temperature for the month was: {avg_temp} degrees. ");
            Console.WriteLine();

            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
