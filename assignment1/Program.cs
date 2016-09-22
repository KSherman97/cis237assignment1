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
    class Program
    {
        // main method of the program class
        // all work is done in this method because 
        // classes are used to externalize processes 
        // into their respective function.
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;  // resets the console bufferhieght to allow the entire file
                                                        // to be read into a single console window

            bool CSVLoaded = false;                     // boolean used to determine if the CSV file has been read or not

            UserInterface UI = new UserInterface();     // instantiates the User Interface class

            int choice = UI.GetUserInput();             // get the user input from the UI class

            WineItem wines = new WineItem();            // instantiates the wineItem class

             WineItemCollection wineItemArrayCollection = new WineItemCollection(); // instantiates the wineItemCollection class

             while (choice != 5)                        // continue until 5(exit code) is entered as the menu value
            {
                if (choice == 1)                        // if the user enters 1 to read the file, do the required tasks
                {
                    if (!CSVLoaded)                     // checks if the CSV file is loaded or not
                    {
                        Console.WriteLine("Reading the file will remove any items you have added!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        CSVCollection readFile = new CSVCollection();               // instantiates the read filereader class

                        readFile.ReadCSV("../../../datafiles/WineList.CSV", wineItemArrayCollection);  // calls the ReadCSV method in the CSV reader class

                        Console.WriteLine("File Read Successful.");                 // let the user know that the file was successfully read
                        CSVLoaded = true;               // set the CSVLoaded bool to true
                    }
                    else                                // lets the user know that the file has already been read
                    {
                        Console.Clear();
                        Console.WriteLine("File Can only be read 1 time");
                    }
                }

                if (choice == 2)                         // if the user enters 2 to display the array contents, do the required tasks
                {
                    Console.Clear();
                    
                    string allOutPut = wineItemArrayCollection.outputArray();       // assigns the allOutPut string to the returned value of the 
                                                                                    // WineItemCollection classes outPutArray method
                    if (allOutPut != string.Empty)                                  // checks to see if there is something to display
                    {
                        UI.PrintAllOutput(allOutPut);                               // print a concatinated line of accumulated values
                    }
                    else                                // There is nothing to display, so let the user know
                    {
                        Console.WriteLine("There is no Data to display. Try loading the file first.");
                    }
                }

                if (choice == 3)                         // if the user enters 3 to search the array contents, do the required tasks
                {
                    Console.Write("Enter the Wine ID to search for: ");             // ask the user for an ID to search for
                    string targetWine = Console.ReadLine();
                    Console.Clear();
                    
                    // assigns the searchResults string to the returned value from the WineItemCollection class's
                    // searchWineItem method using the target wine string passes from this class
                    string searchResults = wineItemArrayCollection.searchWineItem(targetWine);
                    Console.WriteLine(searchResults);   // print said result
                }

                if (choice == 4)                        // if the user enters 4 to add an item to the array, do the required tasks
                {
                    Console.Write("Enter the Wine ID to add: ");                // prompts the user for the ID to add
                    string wineID = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Enter the Wine Name to add: ");              // prompts the user for the name to add
                    string wineName = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Enter the Wine Volume to add: ");            // prompts the user for the volume to add
                    string wineVolume = Console.ReadLine();
                    Console.Clear();

                    // calls the WineItemCollection class's userAddItem method
                    // using the variables wineID, wineName, wineVolume strings passed from this class
                    // if statement prevents empty strings from being added to the array
                    if (wineID != String.Empty && wineName != String.Empty && wineVolume != String.Empty)
                        wineItemArrayCollection.userAddItem(wineID, wineName, wineVolume);
                    else
                        Console.Write("Sorry, you must enter first something in order to add it.");
                }

                // redisplay the main menu when an if statement is done doing its work
                Console.WriteLine("Press any Key to continue.");
                Console.ReadKey(); // wait for the user to press a key
                Console.Clear();
                choice = UI.GetUserInput(); // prompt the user to enter some input again
            }
        }
    }
}
