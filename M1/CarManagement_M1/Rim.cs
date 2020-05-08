using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
{
    public class Rim : Car
    {
        public int Size { get; set; }
        public enum RimColors { Red, White, Black, Yellow, Pink, Blue, Orange, Green }
        public Dictionary<RimColors, int> RimColor = new Dictionary<RimColors, int>();

        //public Color RimColor { get; set; }
        public enum RimTypes { Offroad, Sport, TwoPiece}
        public Dictionary<RimTypes, int> RimType = new Dictionary<RimTypes, int>();


        public Rim( int size, Dictionary<RimColors, int> rimcolor, Dictionary<RimTypes, int> rimtype)
        {
            this.Size = size;
            this.RimColor = rimcolor;
            this.RimType = rimtype;
        }
    }

}

