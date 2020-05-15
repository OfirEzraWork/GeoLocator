using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocator
{
    public class Global
    {
        public string alpha2 { get; set; }
        public string alpha3 { get; set; }
        public string numeric_code { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public string region_code { get; set; }
        public string subregion_code { get; set; }
        public string world_region { get; set; }
        public string continent_name { get; set; }
        public string continent_code { get; set; }
    }

    public class Dial
    {
        public string calling_code { get; set; }
        public string national_prefix { get; set; }
        public string international_prefix { get; set; }
    }

    public class Currency
    {
        public string symbol { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int numeric { get; set; }
        public int minor_unit { get; set; }
    }

    public class Languages
    {
        public string eng { get; set; }
    }

    public class CountryModule
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string common_name { get; set; }
        public string official_name { get; set; }
        public string capital { get; set; }
        public string flag { get; set; }
        public int area { get; set; }
        public bool landlocked { get; set; }
        public bool independent { get; set; }
        public Global global { get; set; }
        public Dial dial { get; set; }
        public IList<Currency> currencies { get; set; }
        public Languages languages { get; set; }
    }

    public class Rise
    {
        public int time { get; set; }
        public int astronomical { get; set; }
        public int civil { get; set; }
        public int nautical { get; set; }
    }

    public class Set
    {
        public int time { get; set; }
        public int astronomical { get; set; }
        public int civil { get; set; }
        public int nautical { get; set; }
    }

    public class SunModule
    {
        public Rise rise { get; set; }
        public Set set { get; set; }
        public int transit { get; set; }
    }

    public class TimezoneModule
    {
        public string name { get; set; }
        public int offset_sec { get; set; }
        public string offset_string { get; set; }
    }

    public class GeoLocation
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public object number { get; set; }
        public object postal_code { get; set; }
        public string street { get; set; }
        public float confidence { get; set; }
        public string region { get; set; }
        public string region_code { get; set; }
        public object county { get; set; }
        public object locality { get; set; }
        public object administrative_area { get; set; }
        public object neighbourhood { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string continent { get; set; }
        public string label { get; set; }
        public IList<double> bbox_module { get; set; }
        public CountryModule country_module { get; set; }
        public SunModule sun_module { get; set; }
        public TimezoneModule timezone_module { get; set; }
        public string map_url { get; set; }
    }
    public class GeoLocationApiResults
    {
        public List<GeoLocation> data { get; set; }
    }
}
