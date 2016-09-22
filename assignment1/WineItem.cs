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
    class WineItem
    {
        // ******************************** 
        //          Backing Fields         
        // ********************************
        private string _wineID;
        private string _wineName;
        private string _wineVolume;

        // ******************************** 
        //            Properties                             
        // ********************************
        public string WineIDString
        {
            get { return _wineID; }
            set { _wineID = value; }
        }

        public string WineNameString
        {
            get { return _wineName; }
            set { _wineName = value; }
        }

        public string WineVolumeString
        {
            get { return _wineVolume; }
            set { _wineVolume = value; }
        }

        // ******************************** 
        //          Constructors                  
        // ********************************
        public WineItem(string wineIDString, string wineNameString, string wineVolumeString)
        {
            this._wineID = wineIDString;
            this._wineName = wineNameString;
            this._wineVolume = wineVolumeString;
        }

        public WineItem() { } // Blank Constructor

        // ToString override method
        // this method makes the WineItem.ToString() 
        // display a concatinated string of the 3 vars
        // wineID, wineName, and wineVolume
        public override string ToString()
        {
            // the this keyword is used to reference 'this' class. 
            // it allows us to reference things that are declard at this classes 'class level'
            return this._wineID + " " + this._wineName + " " + this._wineVolume;
        }
    }
}
