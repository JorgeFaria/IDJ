using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMath
{
    class Maths
    {
       
        public static string Sum(double val1, double val2)
        {
            double soma = val1 + val2;
            return String.Format("{0:F2}", soma);
        }
        public static string Subtract(double val1, double val2)
        {
            double sub = val1 - val2;
            return String.Format("{0:F2}", sub);
        }
        public static string Multiply(double val1, double val2)
        {
            double multi = val1 * val2;
            return String.Format("{0:F2}", multi);
        }
        public static string Devide(double val1, double val2)
        {
            double dev = val1 / val2;
            return String.Format("{0:F2}", dev);
        }
        public static string Percentage(double val1, double val2)
        {
            double dev = val1 * (val2/100);
            return String.Format("{0:F2}", dev);
        }
    }
}


