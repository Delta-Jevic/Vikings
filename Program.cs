/**********************************************************************
*** NAME	    : Jevic Tshilumba                                   ***
*** CLASS	    : Object Oriented Programming                       ***
*** ASSIGNMENT	:  2                                                ***
*** DUE DATE	: 02-26-24                                          ***
*** INSTRUCTOR	: GAMRADT                                           ***
*********************************************************************************************
*** DESCRIPTION : Use Visual Studio Code to create a user-defined Abstract Data Type (ADT) using C# classes named VikingNS and Global along with interface named IView and an appropriate set of C# files as discussed in class                           ***
*********************************************************************************************/
using System;

namespace VikingNS
{
    class Program
    {
        // Main method is the entry point 
        static void Main(string[] args)
        {
            // Creating a new Viking object with default values
            Viking HorizontalLine = new Viking();

            // Display a message indicating horizontal view
            Console.WriteLine("Horizontal view: ");

            // Calling the ViewH method to display Viking information horizontally
            HorizontalLine.ViewH();

            // Adding empty lines for better readability
            Console.WriteLine();
            Console.WriteLine();




            // Creating a new Viking object with specified values
            Viking VerticalLine = new Viking("Ragnar", Global.Status.KARL, 150, Global.Weapon.AXE, false);

            // Display a message indicating vertical view
            Console.WriteLine("\nVertical view");

            // Calling the ViewV method to display Viking information vertically
            VerticalLine.ViewV();
        }
    }
}
