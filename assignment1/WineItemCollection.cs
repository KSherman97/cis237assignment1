using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private int _index;
        private string[] _wineID;
        private string[] _wineName;
        private string[] _wineVolume;
        public WineItemCollection(int actionCode)
        {
            if (actionCode == 1)
            {
                if(wineIDString != null)
                        Console.WriteLine(wineIDString.Length);
                    else
                        Console.WriteLine("There doesn't appear to be anything here");
            }

            if(actionCode == 2)
            {
                Console.WriteLine("Enter a search value: ");
                string searchValue = Console.ReadLine();
                arraySearch(searchValue);
            }
        }

        public WineItemCollection(int subString,  string[] wineIDString, string[] wineNameString, string[] wineVolumeString)
        {
            subString = _index;
            wineIDString = _wineID;
            wineNameString = _wineName;
            wineVolumeString = _wineVolume;


        }

        public int subString
        {
            set { _index = value; }
            get { return _index; }
        }

        public string[] wineIDString
        {
            set { _wineID = value; }
            get { return _wineID; }
        }

        public string[] wineNameString
        {
            set { _wineName = value; }
            get { return _wineName; }
        }

        public string[] wineVolumeString
        {
            set { _wineVolume = value; }
            get { return _wineVolume; }
        }

        private void arraySearch(string targetWine)
        {
            bool found = false;
            int index = 0;
            while (!found && index <= _wineID.Length-1)
            {
                if(_wineID[index] == targetWine)
                {
                    found = true;
                    Console.WriteLine("Wine Could be found");
                }
                else
                {
                    index++;
                }
            }
            Console.WriteLine("Wine Could not be found");
        }
    }
}
