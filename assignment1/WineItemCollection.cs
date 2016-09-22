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
        WineItem[] _wineItemArray = new WineItem[5000];     // creates a new array of type WineItem with 5000 indexes

        // ******************************** 
        //          Backing Fields         
        // ********************************
        private string _wineIDString;
        private string _wineNameString;
        private string _wineVolumeString;

        // ******************************** 
        //          Constructors                  
        // ********************************
        public WineItemCollection() {}                      // blank constructor

        public WineItemCollection(string wineIDString, string wineNameString, string wineVolumeString)
        {
            wineIDString = _wineIDString;
            wineNameString = _wineNameString;
            wineVolumeString = _wineVolumeString;
        }

        // ******************************** 
        //            Properties                             
        // ********************************
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

        // this method is called to add a new wineItem to the array
        public void addWineItem(int index, string wineID, string wineName, string wineVolume)
        {
            _wineItemArray[index] = new WineItem(wineID, wineName, wineVolume); // add a new wineItem object to the array with the passed vars
        }

        // this method is called to search for a specific value that is passed in
        public string searchWineItem(string searchValue)
        {
            bool found = false;                                         // create a new "found" boolean and set it to false
            string results = string.Empty;
            int index = 0;                                              // index used for the loop

            foreach (WineItem wine in _wineItemArray)                   // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
            {
                while (!found && index <= _wineItemArray.Length - 1)    // while the item hasn't been found and the end of the array hasn't been reached
                {
                    if (wine != null)                                   // run a check to make sure the spot in the array is not empty
                    {
                        if (wine.WineIDString == searchValue)           // if a match has been found
                        {
                            found = true;                               // set the found bool to true
                                                                        // concatinated string of the resulting data
                            results = "Wine found!" + Environment.NewLine + "Wine ID: " + wine.WineIDString + Environment.NewLine + "Wine Name: " + wine.WineNameString + Environment.NewLine + "Wine Volume: " + wine.WineVolumeString + Environment.NewLine;
                        }
                        else                                            // if a match has not been found the break the loop
                        {
                            results = "Item could not be found.";
                            break;
                        }
                    }
                    else                                                // if the next line is a null then break the loop
                    {
                        results = "Item could not be found.";
                        break;
                    }
                }
            }
            return results;                                             // return the string determined by the logic above
        }

        // this is the method called when a user wants to add an item by hand
        public void userAddItem(string wineID, string wineName, string wineVolume)
        {
            bool added = false;                                         // new bool 'added'
            string results = string.Empty;
            int index = 0;                                              // int used for the loop

            foreach (WineItem wine in _wineItemArray)                   // foreach(wineItem(Type) wine(pointer to wineItem class) in wineItemCollection(array))
            {
                while (!added && index <= _wineItemArray.Length - 1)    // while the added bool is false and the array is not full
                {
                    if (wine == null)                                   // run a check to make sure the spot in the array empty (able to be added to)
                    {
                        addWineItem(index, wineID, wineName, wineVolume);   // call the addWineItem method
                        added = true;                                       // set added to true
                        Console.WriteLine("Item has been Added!");          // let the user know that everything was successful
                        break;
                    }
                    else
                    {
                        index++;                                        // increase the index if the item has not been added
                    }
                    break;
                }
            }
        }

        // output Array method
        // use to output all items from the array
        public string outputArray()
        {
            string allOutPut = "";                                      // create a new empty string
            foreach (WineItem wine in _wineItemArray)                   // foreach(wineItem(Type) wine(pointer to wineItem class) in wineItemCollection(array))
            {
                if (wine != null)                                       // run a check to make sure the spot in the array is not empty
                {
                    allOutPut += wine.ToString() + Environment.NewLine; // print the employee
                }
            }
            return allOutPut;                                           // return the result of the logic above
        }
    }
}
