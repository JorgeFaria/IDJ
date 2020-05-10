using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement_M1
{
    public class Storage : Car
    {
        public enum CarTypes { SUV, Sport, Van }
        public CarTypes CarType{ get; set; }

        public int Storage_capacity { get; set; }

        public Storage(int storage_capacity, CarTypes cartype)
        {
            this.Storage_capacity = storage_capacity;
            this.CarType = cartype;
        }
    }
}
