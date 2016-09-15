using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        public int GetUserInput()
        {
            this.PrintMainMenu();

            string inputString = Console.ReadLine();
            while(inputString != "1" && inputString != "2" && inputString != "3" && inputString != "4" && inputString != "5")
            {
                Console.Clear();
                Console.WriteLine("That is not a valid option!");
                Console.WriteLine("Please try again.");

                System.Threading.Thread.Sleep(2500);
                Console.Clear();

                this.PrintMainMenu();
                inputString = Console.ReadLine();
            }
            return Int32.Parse(inputString);
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("1) Load Wine List From CSV");
            Console.WriteLine("2) Display Wine List");
            Console.WriteLine("3) Search by ItemID");
            Console.WriteLine("4) Add New Wine to List");
            Console.WriteLine("5) Exit");
        }

    }
}
