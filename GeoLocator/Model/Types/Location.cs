using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocator
{
    public class Location
    {
        //ID wont be given a value in code, the database will grant the location ID which auto incremant
        public int ID { get; set; }
        public string LocationName { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime Date { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string DOW { get; set; }
        public string IP { get; set; }

        public Location()
        {

        }
        public Location(DateTime date,string locationName, string ip)
        {
            Date = date;
            LocationName = locationName;
            IP = ip;

            ExtractDate();
            ValidateIP();

        }

        private void ValidateIP()
        {
            string[] ip = IP.Split('.');
            foreach(string part in ip)
            {
                if(int.Parse(part)>255 | int.Parse(part) < 0)
                {
                    IP = "";
                    break;
                }
            }
        }

        private void ExtractDate()
        {
            Day = Date.Day;
            Month = Date.Month;
            Year = Date.Year;
            Hour = Date.Hour;
            Minute = Date.Minute;
            DOW = Date.DayOfWeek.ToString();
        }
    }
}
