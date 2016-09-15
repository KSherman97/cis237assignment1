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
            UserInterface UI = new UserInterface();
            UI.GetUserInput();

            CSVCollection readFile = new CSVCollection();

            readFile.ReadFile();
        }
    }
}
