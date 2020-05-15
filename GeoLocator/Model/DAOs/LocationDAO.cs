using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoLocator.Model.DAOs
{
    public static class LocationDAO
    {
        public static bool InsertMany(List<Location> locations)
        {
            string dbName = $@"{ConfigurationManager.ConnectionStrings["db"].ConnectionString}";

            foreach(Location location in locations)
            {
                try
                {
                    using (var connection = new SQLiteConnection($"Data Source = {dbName}; Version=3;"))
                    {
                        string cmdString = "INSERT INTO Location " +
                            "(LocationName, Longitude, Latitude, Date, Day, Month, Year, Hour, Minute, DOW, IP) VALUES (" +
                            $"'{location.LocationName}', " +
                            $"{location.Longitude}, " +
                            $"{location.Latitude}, " +
                            $"'{location.Date}', " +
                            $"{location.Day}, " +
                            $"{location.Month}, " +
                            $"{location.Year}, " +
                            $"{location.Hour}, " +
                            $"{location.Minute}, " +
                            $"'{location.DOW}', " +
                            $"'{location.IP}');";
                        connection.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(cmdString, connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;

        }
        public static bool InsertOne(Location location)
        {
            return (InsertMany(new List<Location>() { location }));
        }
    }
}
