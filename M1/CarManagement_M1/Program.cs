using System;
using System.Drawing;
using System.Net.Http;

namespace CarManagement_M1
{
    class Program
    {
        static void Main(string[] args)
        {
           CarInfo carInfo = new CarInfo();

            Console.WriteLine(carInfo.Model);

        }
    }
}
