using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        private string errorCauseString;

        public int GetUserInput()
        {
            this.PrintMainMenu();

            string inputString = Console.ReadLine();
            while (inputString != "1" && inputString != "2" && inputString != "3" && inputString != "4" && inputString != "5")
            {
                ErrorMessageHandling(errorCauseString = "badInput");

                this.PrintMainMenu();
                inputString = Console.ReadLine();
            }
            Console.Clear();
            return Int32.Parse(inputString);
        }

        private void ErrorMessageHandling(string errorCauseString)
        {
            if (errorCauseString == "badInput")
            {
                Console.Clear();
                Console.WriteLine("That is not a valid option!");
                Console.WriteLine("Please try again.");

                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            if (errorCauseString == "multiRead")
            {
                Console.Clear();
                Console.WriteLine("The file can only be read once per run!");
                Console.WriteLine("Please try again.");

                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("An unknown error has occured!");
                Console.WriteLine("Please try again.");

                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("1) Load Wine List From CSV");
            Console.WriteLine("2) Display Wine List");
            Console.WriteLine("3) Search by ItemID");
            Console.WriteLine("4) Add New Wine to List");
            Console.WriteLine("5) Exit");
        }

        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }
    }
}
