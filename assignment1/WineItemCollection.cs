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
