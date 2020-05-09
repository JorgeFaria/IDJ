using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement_M1
{
    public abstract class Storage : Car
    {
        public enum CarTypes { SUV, Sport, Van }

        public Dictionary<CarTypes, int> CarType = new Dictionary<CarTypes, int>();
        public int Storage_capacity { get; set; }

        public Storage(int storage_capacity, Dictionary<CarTypes, int> cartype)
        {
            this.Storage_capacity = storage_capacity;
            this.CarType = cartype;
        }
    }
}
