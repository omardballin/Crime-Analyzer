using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeAnalyzer
{
    public class Data
    {
        public int Year;
        public int Population;
        public int ViolentCrime;
        public int Murder;
        public int Rape;
        public int Robbery;
        public int AggravatedAssault;
        public int PropertyCrime;
        public int Burglary;
        public int Theft;
        public int MotorVehicleTheft;


        public Data(int year, int population, int violentCrime, int murder,int rape, int robbery, int aggravatedAssault, int propertyCrime, int burglary, int theft, int motorVehicleTheft)
        {
            Year = year;
            Population = population;
            ViolentCrime = violentCrime;
            Murder = murder;
            Rape = rape;
            Robbery = robbery;
            AggravatedAssault = aggravatedAssault;
            PropertyCrime = propertyCrime;
            Burglary = burglary;
            Theft = theft;
            MotorVehicleTheft = motorVehicleTheft;
        }
    }
}
