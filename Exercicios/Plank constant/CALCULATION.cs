using System;
using System.Collections.Generic;
using System.Text;

namespace Plank_constant
{
    
    class CALCULATION
    {
        public static decimal plank = 6.62606896e-34M;
        public static decimal pi = 3.14159M;
        public static decimal res;
        public string Calculo()
        {
            res = plank / (2 * pi);

            return String.Format("{0}", res);
        }
    }
}
