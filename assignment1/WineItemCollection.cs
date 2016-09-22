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
    class WineItemCollection
    {
        WineItem[] _wineItemArray = new WineItem[5000];

        
        private string _wineIDString;
        private string _wineNameString;
        private string _wineVolumeString;

        public WineItemCollection() {}

        public WineItemCollection(string wineIDString, string wineNameString, string wineVolumeString)
        {
            wineIDString = _wineIDString;
            wineNameString = _wineNameString;
            wineVolumeString = _wineVolumeString;
        }

        public string wineIDString
        {
            set { _wineIDString = value; }
            get { return _wineIDString; }
        }

        public string wineNameString
        {
            set { _wineNameString = value; }
            get { return _wineNameString; }
        }

        public string wineVolumeString
        {
            set { _wineVolumeString = value; }
            get { return _wineVolumeString; }
        }

        public void addWineItem(int index, string wineID, string wineName, string wineVolume)
        {
            _wineItemArray[index] = new WineItem(wineID, wineName, wineVolume);
        }

        public string searchWineItem(string searchValue)
        {
            bool found = false;
            string results = string.Empty;
            int index = 0;

            foreach (WineItem wine in _wineItemArray) // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
            {
                while (!found && index <= _wineItemArray.Length - 1)
                {
                    // run a check to make sure the spot in the array is not empty
                    if (wine != null)
                    {
                        if (wine.WineIDString == searchValue)
                        {
                            found = true;
                            results = "Wine found!" + Environment.NewLine + "Wine ID: " + wine.WineIDString + Environment.NewLine + "Wine Name: " + wine.WineNameString + Environment.NewLine + "Wine Volume: " + wine.WineVolumeString + Environment.NewLine;
                        }
                        else
                        {
                            results = "Item could not be found.";
                            break;
                        }
                    }
                    else
                    {
                        results = "Item could not be found.";
                        break;
                    }
                }
            }
            return results;
        }

        public void userAddItem(string wineID, string wineName, string wineVolume)
        {
            bool found = false;
            string results = string.Empty;
            int index = 0;

            foreach (WineItem wine in _wineItemArray) // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
            {
                while (!found && index <= _wineItemArray.Length - 1)
                {
                    // run a check to make sure the spot in the array is not empty
                    if (wine == null)
                    {
                        _wineItemArray[index] = new WineItem(wineID, wineName, wineVolume);
                        found = true;
                        Console.WriteLine("Item has been Added!");
                        break;
                    }
                    else
                    {
                        index++;
                    }
                    break;
                }
            }
        }

        public string outputArray()
        {
            string allOutPut = "";
            foreach (WineItem wine in _wineItemArray) // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
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

            return allOutPut;
        }
    }
}
