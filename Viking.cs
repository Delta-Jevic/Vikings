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
    // Define the Viking class, which implements the IView interface
    public class Viking : IView
    {
        // Properties to represent various attributes of a Viking
        public string Name { get; set; }
        public Global.Status Status { get; set; }
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }

        // Constructor to initialize the Viking object with default values
        public Viking(string name = "Bjorn", Global.Status status = Global.Status.KARL, short health = 150, Global.Weapon weapon = Global.Weapon.AXE, bool shield = false)
        {
            Name = name;
            Status = status;
            Health = health;
            Weapon = weapon;
            Shield = shield;
        }

        // Copy constructor to create a new Viking object based on an existing Viking object
        public Viking(Viking viking)
        {
            Name = viking.Name;
            Status = viking.Status;
            Health = viking.Health;
            Weapon = viking.Weapon;
            Shield = viking.Shield;
        }

        // Method to display Viking information in horizontal format
        public void ViewH()
        {
            // Display column headers
            Console.WriteLine("Name\tStatus\tHealth\tWeapon\tShield");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", Name, Status, Health, Weapon, Shield);
        }

        // Method to display Viking information in vertical formt
        public void ViewV()
        {
            // Display Viking information with each attribute on a new line
            Console.WriteLine("Name:           {0}", Name);
            Console.WriteLine("Status:         {0}", Status);
            Console.WriteLine("Health:         {0}", Health);
            Console.WriteLine("Weapon:         {0}", Weapon);
            Console.WriteLine("Shield:         {0}", Shield);
        }
    }
}


