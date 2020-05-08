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
        public enum FrontBumperColors { Red, White, Black, Yellow, Pink, Blue, Orange, Green }
        public Dictionary<FrontBumperColors, int> FrontBumperColor = new Dictionary<FrontBumperColors, int>();
       
        public enum BackBumperColors { Red, White, Black, Yellow, Pink, Blue, Orange, Green }
        public Dictionary<BackBumperColors, int> BackBumperColor = new Dictionary<BackBumperColors, int>();
        public enum SkirtColors { Red, White, Black, Yellow, Pink, Blue, Orange, Green }
        public Dictionary<SkirtColors, int> SkirtColor = new Dictionary<SkirtColors, int>();

        public Bumpers_skirt(int frontBumper_id, int backBumpercolor, int skirt_id, Dictionary<FrontBumperColors, int> frontBumperColor, Dictionary<BackBumperColors, int> backBumperColor, Dictionary<SkirtColors, int> skirtColor)
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
