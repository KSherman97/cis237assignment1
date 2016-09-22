using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            bool CSVLoaded = false;

            UserInterface UI = new UserInterface();

            // get the user input from the UI class
            int choice = UI.GetUserInput();

            WineItem wines = new WineItem();

             WineItemCollection wineItemArrayCollection = new WineItemCollection();

            // continue until 2(exit) is entered as the menue value

            while (choice != 5)
            {
                // if the user enters the 1(print out employees) do the required work
                if (choice == 1)
                {
                    if (!CSVLoaded)
                    {
                        Console.WriteLine("Reading the file will remove any items you have added!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        CSVCollection readFile = new CSVCollection();

                        readFile.ReadCSV("WineList.CSV", wineItemArrayCollection);

                        //Console.Clear();

                        // a foreach loop. It is usefull for doing a collection of objects
                        // Each object in the array 'employees' will get assigned to the local variable 'employee' inside the loop
                        Console.WriteLine("File Read Successful.");
                        CSVLoaded = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("File Can only be read 1 time");
                    }
                }

                if(choice == 2)
                {
                    Console.Clear();
                    
                    string allOutPut = wineItemArrayCollection.outputArray();
                    if (allOutPut != string.Empty)
                    {
                        UI.PrintAllOutput(allOutPut); // print the concatinated line of accumulated values
                    }
                    else
                    {
                        Console.WriteLine("There is no Data to display. Try loading the file first.");
                    }
                }

                if(choice == 3)
                {
                    Console.Write("Enter the Wine ID to search for: ");
                    string targetWine = Console.ReadLine();
                    Console.Clear();
                    string searchResults = wineItemArrayCollection.searchWineItem(targetWine);
                    Console.WriteLine(searchResults);
                }

                if(choice == 4)
                {
                    Console.Write("Enter the Wine ID to add: ");
                    string wineID = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Enter the Wine Name to add: ");
                    string wineName = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Enter the Wine Volume to add: ");
                    string wineVolume = Console.ReadLine();
                    Console.Clear();
                    wineItemArrayCollection.userAddItem(wineID, wineName, wineVolume);
                }

                Console.WriteLine("Press any Key to continue.");
                Console.ReadKey(); // wait for the user to press a key
                Console.Clear();
                choice = UI.GetUserInput(); // prompt the user to enter some input again
            }
        }
    }
}
