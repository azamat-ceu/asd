using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VIN_LIB
{
    public class VIN
    {
        bool CheckVIN(string vin)
        {
            Regex vi = new Regex(@"[A-H,J-N,P,R-Z,\d]{17}");
            if (!vi.IsMatch(vin)) return false;
        }
        string GetVINCountry(string vin)
        {

        }
        int GetTransportYear(string vin)
        {

        }
    }
}
