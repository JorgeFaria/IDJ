using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
{
    public class Rim : Car
    {
        public int RimHealth { get; set; }
        public int Size { get; set; }
        public Color RimColor { get; set; }
        public enum RimTypes { Offroad, Sport, Drag}

        public Dictionary<RimTypes, int> RimType = new Dictionary<RimTypes, int>();

        public Rim(int rim_health, int size,Dictionary<RimTypes, int> rimtype, Color rim_color)
        {

            this.RimHealth = rim_health;
            this.Size = size;
            // this.Type = type;
            this.RimColor = rim_color;
            this.RimType = rimtype;
        }

        public Rim()
        {
            this.RimHealth = 100;
            this.Size = 15;
            this.RimColor = Color.White;
            this.RimType = new Dictionary<Rim.RimTypes, int>
            {
                {RimTypes.Offroad,0},
                {RimTypes.Sport,0},
                {RimTypes.Drag ,0}
            };
        }

    }

}

