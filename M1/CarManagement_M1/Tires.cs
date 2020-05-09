using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement_M1
{
    class Tires : Car
    {
        public int Grip { get; set; }
        public int Wear { get; set; }
        public enum TireTypes { Offroad, Sport, Drag }
        public Dictionary<TireTypes, int> TireType = new Dictionary<TireTypes, int>();

        public Tires(int grip, int wear, Dictionary<TireTypes, int> tiretype)
        {
            this.Grip = grip;
            this.Wear = wear;
            this.TireType = tiretype;
        }
    }
}