using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine(" Crime Analyzer");
                Console.WriteLine("CrimeAnalyzer <crime_csv_file_path> <report_file_path>");
                Environment.Exit(1);
                string csvDataFilePath = args[0];
                string reportFilePath = args[1];

                List<Data> crimeStatsList = null;
                try
                {
                    crimeStatsList = CrimeStatsLoader.Load(csvDataFilePath);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(2);
                }

                var report = DataReport.GenerateText(crimeStatsList);

                try
                {
                    System.IO.File.WriteAllText(reportFilePath, report);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                }
            }
        }
    }
