using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement_M1
{
    class CarInfo : CarDatabase
    {
        public List<Car> carInfo = new List<Car>();

        public CarInfo()
        {
            BuildCarDatabase();
        }
    }
}
