using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocator
{
    interface FileReader
    {
        void ReadFile(string path);
        List<Location> GetLocations();
        bool ContainsRecords();
    }
}
