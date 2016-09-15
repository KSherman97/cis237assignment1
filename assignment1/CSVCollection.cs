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

        public void ReadFile()
        {
            // var reader = new StreamReader(File.OpenRead(Environment.CurrentDirectory + "WineList.csv"));

            string[] wineIDString = new string[5000];
            string[] wineNameString = new string[5000];
            string[] wineVolumeString = new string[5000];

            int subCounter = 0;

            string filePathString = Environment.CurrentDirectory + "/" + "WineList.csv";
            StreamReader streamReader = new StreamReader(filePathString);

            var lines = new List<string[]>();
            int Row = 0;
            while (!streamReader.EndOfStream)
            {
                string[] Line = streamReader.ReadLine().Split(',');
                lines.Add(Line);
                Row++;
                Console.WriteLine(Row);
            }

            var data = lines.ToArray();


        }
    }
}
