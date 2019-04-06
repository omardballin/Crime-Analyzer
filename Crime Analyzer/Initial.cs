using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeAnalyzer
{
    class Initial
    {
        private static int NumItemsInRow = 11;

        public static List<Data> Load(string csvDataFilePath)
        {
            List<Data> crimeStatsList = new List<Data>();

            try
            {
                using (var reader = new StreamReader(csvDataFilePath))
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        lineNumber++;
                        if (lineNumber == 1) continue;

                        var values = line.Split(',');

                        if (values.Length != NumItemsInRow)
                        {
                            throw new Exception($"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}.");
                        }
                    }
                }
            }
        }
}
