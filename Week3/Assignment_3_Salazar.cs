/* Author : Alvaro Salazar
 * Date   : September 14, 2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

    class changeValue
    {
    /* Specification: Create a class called changeValue that declares 2 integer 
     * class variables:  value1 and value2.  These should be declared as public
    *  and you should not use automatic properties to declare them.
    *  Your class should have a constructor that initializes the two class
    *  variables.
    *  In the class provide a method printit() that displays the result of 
    *  multiplying value1 and value2.
    *  In the default wrapper class named assignment3 and containing Main write
    *  the code in Main that declares two integer variables: val1 and val2.
    *  Use Console Write and Readline and the convert method to take the two 
    *  integer entries from the keyboard and pass them to the changeValue
    *  constructor.
    *  Instantiate a changeValue object and pass the two integer values to the
    *  constructor.
    *  Conditions:
    *  In the changeValue constructor evaluate the two input values that were
    *  passed using if statements:
    *  if val1 is greater than 5 then set class variable value1 equal to the
    *  first value passed to the constructor.
    *  if val1 is less than or equal to 5 then set class variable value1 equal
    *  to the first passed value plus the second passed value.
    *  if val2 is less than 10 then set class variable value2 equal to the 
    *  second passed value times the second passed value and then add 5.
    *  if val2 is greater to or equal to 10 then set class variable value2 equal 
    *  to the second passed value.
    *  From Main call the printit method which will print the resulting computed 
    *  values in the class object.
    *  
    *  Example:
    *  Enter an integer value: 8
    *  Enter a second integer value: 3
    *  The calculated value is: 112
    *  Press any key to continue . . .
    */

        private int value1;
        private int value2;

        public int Value1 // public property for value1, not automatic properties
        {
            // propety contains get and set so it is read-write
            get
            {
                return value1; 
            }
            set
            {
                value1 = value;
            }
        }

        public int Value2 // public property for value2, not automatic properties
        {
            // propety contains get and set so it is read-write
            get
            {
            return value2;
            }
            set
            {
                value2 = value;
            }
        }

        public changeValue(int val1, int val2) // Constructor with two arguments
        {

            //here is the constructor where you code the if statements
            // if val1 is greater than 5 then set class variable value1 equal
            // to the first value passed to the constructor.
            if (val1 > 5) // if val1 
            {
                value1 = val1;
            }
            // if val1 is less than or equal to 5 then set class variable value1
            // equal to the first passed value plus the second passed value.
            else  
            {
                value1 = val1 + val2;
            }

            // if val2 is less than 10 then set class variable value2 equal to
            // the second passed value times the second passed value and then
            // add 5.
            if (val2 < 10)
            {
                value2 = (val2 * val2) + 5;
            }
            // if val2 is greater to or equal to 10 then set class variable
            // value2 equal to the second passed value.
            else
            {
                value2 = val2;
            }
        }  // End constructor

        // print the results
        public void printit()
        {
            //here is the printit method used to print the results
            Console.WriteLine("The calculated value is: " + (value1 * value2) );
              
        }
    } // End class changeValue

    class assignment3
    {
        public static void Main(string[] args)
        {
            //declare the local val1 and val2 integer variables
            int val1;
            int val2;

            //prompt the user for input of two integers

            // Request the first Value
            Console.Write("Enter an integer value: ");

            // Convert from the string input to integer
            val1 = Convert.ToInt32(Console.ReadLine());

            // Request the Second Value
            Console.Write("Enter a second integer Value: ");

            // Convert from the string input to integer
            val2 = Convert.ToInt32(Console.ReadLine());

            //instantiate a changeValue object 
            changeValue changev = new changeValue(val1, val2);
            
            //call the object method printit here
            changev.printit();

        }
    }

