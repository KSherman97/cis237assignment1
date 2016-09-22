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
using System.IO;

namespace assignment1
{
    class CSVCollection
    {
        WineItemCollection addWineItem = new WineItemCollection();  // instantiates the WineItemCollection class
        
        // CSV Reader
        // dependency injection: https://msdn.microsoft.com/en-us/library/hh323705(v=vs.100).aspx
        // This method does handles the reading of the CSV File
        // both the path to the CSV and a new wineItemCollection object are passed in
        public bool ReadCSV(string pathToCSVFile, WineItemCollection wines)
        {
            // declares a new variables for a StreamReader object. Not instantiating it yet
            StreamReader streamReader = null;           // requiers: using System.IO; set default to null

            try                                         // start a try catch since the path to the file could be incorrect, 
            {                                           // and thus throwing an exception

                string line;                            // Declare a string for each line we will read in

                streamReader = new StreamReader(pathToCSVFile); // instantiate the streamreader object


                int counter = 0;                        // initialize a counter variable to 0 for the while loop

                 // check if the file has reached a null yet
                 // while there is a line to read, read it and put it in the line var
                 while ((line = streamReader.ReadLine()) != null)
                 {
                     // call the process line method and send over the read in line 
                     // the wineItemCollection array (which is passed by reference automatically)
                     // and the counter, which will be used as the index for the array.
                     // incrementing the counter after we send it in with the ++ operator
                     processLine(line, wines, counter++);
                 }
                 return true;                           // once the end of the file has been reached, return true
             }
             catch (Exception Ex)
             {
                 // if something went wrong then print it to the console
                 Console.WriteLine(Ex.ToString() + Environment.NewLine + Ex.StackTrace);
                 return false;                          // return false, stating that an exception has occured
             }
             finally                                    // once the try / catch has completed, finish doing this stuff. 
             {                                          // Do it whether try is successful or not
                 // if there is a file to close then you need to close it before continuing on with the program
                 if (streamReader != null)
                 {
                     streamReader.Close();
                 }
             }
        }

        // this method handles the processing of each individual line read into the CSV reader
        private void processLine(string line, WineItemCollection wines, int index)
        {
            var parts = line.Split(',');            // declares a string array and assigns the split line to it.

            // assign the parts to local variables that mean something
            string wineID = parts[0];
            string wineName = parts[1];
            string wineVolume = parts[2];

            // Use the variables to instanciate a new wineItem and assign it to 
            // the spot in the wineItemCollection array indexed by the index that was passed in.
            wines.addWineItem(index, wineID, wineName, wineVolume);
        }
    }
}
