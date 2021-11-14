/* Author : Alvaro Salazar
 * Date   : September 12, 2021
 */
using System;


public class compute_product
{
    /* Specification: This program compute and display the product of 2 numbers. 
    
    * Example:
    * value 1 = 5
    * value 2 = 10
    *
    * Output:
    * The product is 50
    * 
    * return : None
    * Parameters: None
    *  
    */

    private int value1; // private field
    private int value2; // private field

    // instance variable for the Value2
    public int Value2 { get; set; }

    public compute_product(int number1) // Constructor 1 parameter
    {
        value1 = number1;
    }

    public compute_product() // Constructor
    {
    }

    // display the product. 
    public void display_product_calc()
    {
    // the product to the console
        Console.WriteLine("The product is " + value1 * Value2 ) ;
    } // end method Display_product_calc 
} // end class compute_product

public class compute_productTest
{
    public static void Main(string[] args)
    {
        //instantiate a new compute_product object here, passing the
        //the Value2
        int myValue1 = 5;
        compute_product myproduct = new compute_product(myValue1);  //instantiates object of type compute_product
        myproduct.Value2  = 10;
        
        myproduct.display_product_calc() ;
        
        Console.WriteLine(); // output a new line
    } // end Main
} // end class compute_productTest
