using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrimeAnalyzer
{
    public class DataReport
    {
        public static class CrimeStatsReport
        {
            public static string GenerateText(List<Data> crimeStatsList)
            {
                string report = "Crime Analyzer Report\n\n";

                var startYear = (from crimeStats in crimeStatsList select crimeStats.Year).Min();
                var endYear = (from crimeStats in crimeStatsList select crimeStats.Year).Max();

                report += $"Period: {startYear}-{endYear} ({crimeStatsList.Count} years)\n";


                report += "Years murders per year < 15000: ";
                var years = from crimeStats in crimeStatsList where crimeStats.Murder < 15000 select crimeStats.Year;
                if (years.Count() > 0)
                {
                    foreach (var year in years)
                    {
                        report += year + ",";

                    }
                    report.TrimEnd(',');
                    report += "\n";
                }
                else
                {
                    report += "not available\n";
                }
            }
        }
    }
}
