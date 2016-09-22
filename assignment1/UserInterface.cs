/**
 * Kyle Sherman
 * CIS 237 - Advanced C# Programming
 * 9/22/2016
**/

// standard imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {              
        // this is the method that gets handles user input and returns it as a string
        public int GetUserInput()
        {
            this.PrintMainMenu();                       // calls the PrintMainMenue method

            string inputString = Console.ReadLine();    // gets the users input

            // while loop checking for propper user input,
            // the user must enter a 1, 2, 3, 4, 5
            // the input cannot be blank
            while (inputString != "1" && inputString != "2" && inputString != "3" && inputString != "4" && inputString != "5" && inputString != string.Empty && inputString != null)
            {
                Console.Clear();
                Console.WriteLine("That is not a valid option!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                                
                Console.Clear();

                this.PrintMainMenu();                               // print the main menu again
                inputString = Console.ReadLine();                   // get the user input
            }
            Console.Clear();

            // This try catch trys to parse the users input
            // checks if the users input is propper
            try
            {
                return Int32.Parse(inputString);                    // parse the input from the user
            }
            catch(Exception EX)                                     // catch any exceptions thrown
            {
                Console.Clear();
                Console.WriteLine("Input cannot be empty and must be a number");
                Console.WriteLine("Please try again.");
                return 0;
            }
        }

        // this method holds the console.WriteLines for the main menu
        // called by the method above
        private void PrintMainMenu()
        {
            Console.WriteLine("1) Load Wine List From CSV");
            Console.WriteLine("2) Display Wine List");
            Console.WriteLine("3) Search by ItemID");
            Console.WriteLine("4) Add New Wine to List");
            Console.WriteLine("5) Exit");
        }

        // this method is used to print the output result of the WineItemCollection array
        // string is passed in from the wineItemCollection class when called
        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }
    }
}
