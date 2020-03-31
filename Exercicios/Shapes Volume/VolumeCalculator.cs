using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Volume
{
    class VolumeCalculator
    {
        public static string VolumeCube(double val1)
        {
            double volumecubo = val1 * val1 * val1;
            return String.Format("{0:F3}", volumecubo);
        }
        public static string VolumeCylinder(double val1,double val2)
        {
            double areaBase = 3.14 * (val1 * val1); 
            double volumeCylinder = areaBase * val2;
            return String.Format("{0:F3}", volumeCylinder);
        }
        public static string VolumeTrianglePrism(double val1, double val2,double val3)
        {
            double volumeCylinder = (val1 * val2 * val3) / 2;
            return String.Format("{0:F3}", volumeCylinder);
        }
    }
}
