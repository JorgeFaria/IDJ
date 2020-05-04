using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement_M1
{
    public abstract class Tires
    {
        public int Grip { get; set; }
        public int Wear { get; set; }
        public string Type { get; set; }

        public Tires(int grip, int wear, string type)
        {
            this.Grip = grip;
            this.Wear = wear;
            this.Type = type;
        }
    }
}