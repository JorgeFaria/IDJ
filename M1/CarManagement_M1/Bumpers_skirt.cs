using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
{
   public  class Bumpers_skirt : Car
    {
        //bumpers id unique to each type of bumper
        public int FrontBumper_id { get; set; }
        public int BackBumper_id { get; set; }
        public int Skirt_id { get; set; }

        //RGB colors for bumpers and skirts
        public enum FrontBumperColors { Red, Green, Blue }
        public Dictionary<FrontBumperColors, int> FrontBumperColor = new Dictionary<FrontBumperColors, int>();
       
        public enum BackBumperColors { Red, Green, Blue}
        public Dictionary<BackBumperColors, int> BackBumperColor = new Dictionary<BackBumperColors, int>();
        public enum SkirtColors { Red, Green, Blue }
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
