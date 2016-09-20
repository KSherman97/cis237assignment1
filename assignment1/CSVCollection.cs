using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVCollection
    {
        WineItemCollection addWineItem = new WineItemCollection();
        // CSV Reader
        // dependency injection (good coding practice) https://msdn.microsoft.com/en-us/library/hh323705(v=vs.100).aspx
        public bool ReadCSV(string pathToCSVFile, WineItemCollection wines)
        {
            
            // declares a new variables for a StreamReader object. Not instantiating it yet
            StreamReader streamReader = null;// requiers: using System.IO; set default to null

             // start a try since the path to the file could be incorrect, and thus throwing an exception
             try
             {
                 // Declare a string for each line we will read in
                 string line;

                 // instantiate the streamreader object
                 streamReader = new StreamReader(pathToCSVFile);

                 // initialize a counter variable to 0 for the while loop
                 int counter = 0;

                 // check if the file has reached a null yet
                 // while there is a line to read, read it and put it in the line var
                 while ((line = streamReader.ReadLine()) != null)
                 {
                     // call the process line method and send over the read in line 
                     // the employees array (which is passed by reference automatically)
                     // and the counter, which will be used as the index for the array.
                     // We are also incrementing the counter after we send it in with the ++ operator
                     processLine(line, wines, counter++);
                 }
                 return true; // once the end of the file has been reached, return true
             }
             catch (Exception Ex)
             {
                 // if something went wrong then print it to the console
                 Console.WriteLine(Ex.ToString() + Environment.NewLine + Ex.StackTrace);
                 return false; // return false, stating that an exception has occured
             }
             finally // once the try / catch has completed, finish doing this stuff. Do it whether try is successful or not
             {
                 // if there is a file to close then you need to close it before continuing on with the program
                 if (streamReader != null)
                 {
                     streamReader.Close();
                 }
             }
        }

        private void processLine(string line, WineItemCollection wines, int index)
        {
            // declares a string array and assigns the split line to it.
            var parts = line.Split(',');

            // assign the parts to local variables that mean something
            string wineID = parts[0];
            string wineName = parts[1];
            string wineVolume = parts[2];

            // Use the variables to instanciate a new employee and assign it to 
            // the spot in the employees array indexed by the index that was passed in.
            wines.addWineItem(index, wineID, wineName, wineVolume);
            //addToCollection(index, wineID, wineName, wineVolume);
        }
    }
}
