/* Author : Alvaro Salazar
 * Date   : September 12, 2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class average
{
    /* Specification: This program set three integers, adds all three together, 
    * computes an average, and computes any remainder of the 
    * integer division.
    * Example:
    * score 1 = 3
    * score 2 = 4
    * score 3 = 6
    * The average of 3, 4, 6 is 4 with a remainder of 1
    * 
    * return : None
    * Parameters: None
    *  
    */
    //You do not have to implement the automatic properties, use these.
    //
    // auto-implemented property Score1 implicitly creates an
    // instance variable for the score1
    public int Score1 { get; set; }

    // auto-implemented property Score2 implicitly creates an
    // instance variable for the score2
    public int Score2 { get; set; }

    // auto-implemented property Score3 implicitly creates an
    // instance variable for the score3
    public int Score3 { get; set; }

    //declare the remainder and avg variables (use these)
    int remainder;
    int avg;

    // constructor shell accepting three values, you fill in the 
    //rest of the code
    public average(int score1Value, int score2Value, int score3Value)
    {
        //write code here to set each class instance variable to the
        //values you passed to the constructor (average)
        score1Value = 0;
        score2Value = 0;
        score3Value = 0;

    } // end three-parameter constructor

    public average()
    {
    }

    // calculate the average of the three scores
    public void computeAverage()
    {
        // Compute avg
        int sum = Score1 + Score2 + Score3;
        avg = sum / 3;
        // Compute the remainder
        remainder = sum % 3;
    } // end method computeAverage


    // display the average. 
    public void DisplayAverage()
    {
        // Output the three variables,
        // the average and the remainder to the console
        Console.WriteLine("The average of " + Score1 + ", " + Score2
                + ", " + Score3 + " is " + avg + " with a remainder of "
                + remainder);
    } // end method DisplayAverage 
} // end class average

public class averageTest
{
    public static void Main(string[] args)
    {
        //instantiate a new average object here, passing the
        //the score1, score2 and score3 values respectively 
        average myaverage = new average();  //instantiates object of type average
        myaverage.Score1 = 3;
        myaverage.Score2 = 4;
        myaverage.Score3 = 6;

        myaverage.computeAverage();
        myaverage.DisplayAverage();

        Console.WriteLine(); // output a new line
    } // end Main
} // end class averageTest
