using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoLocator
{
    static class GeoLocationApiConnector
    {
        static public async void GetCoordsMany(List<Location> locations)
        {
            //using positionstack.com free api

            foreach (Location location in locations)
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://api.positionstack.com/v1/forward"
                                    + $"?access_key={ConfigurationManager.AppSettings["PositionStackApiKey"]}"
                                    + $"&query={location.LocationName}");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.GetAsync("").Result;
                    if (response.IsSuccessStatusCode)
                    {

                        GeoLocationApiResults geoLocationApiResults = JsonConvert.DeserializeObject<GeoLocationApiResults>(await response.Content.ReadAsStringAsync());
                        if (geoLocationApiResults.data.Count > 0)
                        {
                            location.Latitude = geoLocationApiResults.data[0].latitude;
                            location.Longitude = geoLocationApiResults.data[0].longitude;
                        }
                        else
                        {
                            location.Latitude = 0;
                            location.Longitude = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error contacting user web service\n{(int)response.StatusCode} ({response.ReasonPhrase})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        static public void GetCoordsOne(Location location)
        {
            GetCoordsMany(new List<Location>() { location });
        }

    }
}
