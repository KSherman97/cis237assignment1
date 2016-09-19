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
            // int choice = StaticUserInterface.GetUserInput(); // example with using the static UI class

            // continue until 2(exit) is entered as the menue value
            string allOutPut = "";
            while (choice != 5)
            {
                // if the user enters the 1(print out employees) do the required work
                if (choice == 1)
                {
                    if (!CSVLoaded)
                    {
                        WineItem wines = new WineItem();
                        WineItem[] wineItem = new WineItem[5000];
                        CSVCollection readFile = new CSVCollection();

                        readFile.ReadCSV("WineList.CSV", wineItem);

                        //Console.Clear();

                        // a foreach loop. It is usefull for doing a collection of objects
                        // Each object in the array 'employees' will get assigned to the local variable 'employee' inside the loop
                        foreach (WineItem wine in wineItem) // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
                        {
                            // run a check to make sure the spot in the array is not empty
                            if (wine != null)
                            {
                                // print the employee
                                allOutPut += wine.ToString() + Environment.NewLine;
                                //Console.WriteLine(wine);
                            }
                        }
                        //UI.PrintAllOutput(allOutPut);

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
                    UI.PrintAllOutput(allOutPut); // print the concatinated line of accumulated values
                    
                }

                if(choice == 3)
                {

                }

                if(choice == 4)
                {

                }

                Console.WriteLine("Press any Key to continue.");
                Console.ReadKey(); // wait for the user to press a key
                Console.Clear();
                choice = UI.GetUserInput(); // prompt the user to enter some input again
            }
        }
    }
}
