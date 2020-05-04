using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement_M1
{
    public abstract class Storage
    {
        public int Storage_capacity { get; set; }

        public Storage(int storage_capacity)
        {
            this.Storage_capacity = storage_capacity;
        }
    }
}
