using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
{
   public abstract class Bumpers_skirt
    {
        public int FrontBumper_id { get; set; }
        public int BackBumper_id { get; set; }
        public int Skirt_id { get; set; }
        public Color FrontBumperColor { get; set; }
        public Color BackBumperColor { get; set; }
        public Color SkirtColor { get; set; }

        public Bumpers_skirt(int frontBumper_id, int backBumpercolor, int skirt_id, Color frontBumperColor, Color backBumperColor, Color skirtColor)
        {
            this.FrontBumper_id = frontBumper_id;
            this.BackBumper_id = backBumpercolor;
            this.Skirt_id = skirt_id;
            this.FrontBumperColor = frontBumperColor;
            this.BackBumperColor = backBumperColor;
            this.SkirtColor = skirtColor;
        }
    }
}
