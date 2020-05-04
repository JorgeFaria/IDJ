using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
    
{
    public class Car : Rim
    {
        
        public int Armor { get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public int Health { get; set; }
        public double Speed { get; set; }

        public Car(int armor, string make, string model, Color color, int health, float speed, int rim_health, int size, string type, Color rim_color) :base(rim_health,size,type,rim_color)
        {
            this.Armor = armor;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Health = health;

        //    (Axle Ratio x v x Transmission Ratio x 336.13) / Tire Diameter ] =  [(3.73 x 65 x 1.00 x 336.13) / 31 ] = [2628]
        //Note: 336.13 is used to convert the result to RPM = [63360 inches per mile / (60 minutes per hour x Pi.)]

          double v = 0.00595 * (1000 * size);
          var temp_speed = v;

            var rpm = ((3.73 * v * 1 * 336.13) / size);

            this.Speed = 0.00595 * (rpm * size);
        }

       
    }
}

    

