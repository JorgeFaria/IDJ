using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
{
    public class Rim
    {

        public int RimHealth { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public Color RimColor { get; set; }

        public Rim(int rim_health, int size, string type, Color rim_color)
        {
           
            this.RimHealth = rim_health;
            this.Size = size;
            this.Type = type;
            this.RimColor = rim_color;
        }
        }
    }

