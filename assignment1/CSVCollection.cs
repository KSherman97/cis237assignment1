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

        static void Main(string[] args)
        {
            // var reader = new StreamReader(File.OpenRead(Environment.CurrentDirectory + "WineList.csv"));

            string[] wineIDString = new string[5000];
            string[] wineNameString = new string[5000];
            string[] wineVolumeString = new string[500];

            int subCounter = 0;

            string filePathString = Environment.CurrentDirectory + "WineList.csv";
            StreamReader streamReader = new StreamReader(filePathString);
            
            for (subCounter = 0; subCounter < 5000; subCounter++)
            {
                if(streamReader.Peek() != -1)
                {
                    wineIDString[subCounter] = (streamReader.ReadLine());
                    wineNameString[subCounter] = (streamReader.ReadLine());
                    wineVolumeString[subCounter] = (streamReader.ReadLine());
                }
            }



        }
    }
}
