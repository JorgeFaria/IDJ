using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
    
{
    public class Car
    {
        //Boolean to detect if car hits something
        private bool hit=false;

        //public Color finalColor;
        //private int color_r;
        //private int color_g;
        //private int color_b;
        //Car armor
        public int Armor { get; set;}

        //can add more makes to enum
        public enum Makes { Fard, Hando, Lambirghini, Ferruri }
        public Makes Make { get; set; }

        //can add more models to enum
        public enum Models { Festa, Civec, Gallirdo, Speciale }
        public Models Model { get; set; }

        //Colors set to RGB
        public enum CarColors { Red, Green, Blue }
        public Dictionary<CarColors, int> CarColor = new Dictionary<CarColors, int>();
        
        //Car health
        public int Health { get; set; }

        //Car speed
        public double Speed { get; set; }

        public int Color_r { get ; set ; }
        public int Color_g { get; set ; }
        public int Color_b { get; set; }

        public Car(int armor, Makes make, Models model , Dictionary<CarColors, int> carcolor, int health, float speed)
        {
            this.Armor = armor;
            this.Make = make;
            this.Model = model;
            this.CarColor = carcolor;
            this.Health = health;
        }

        // Base values for car
        public Car()
        {
            this.Armor = 100;
            this.Make = Makes.Fard;
            this.Model = Models.Gallirdo;
           
            //this.color_r = (int)CarColors.Red;
            //this.color_g = (int)CarColors.Green;
            //this.color_b = (int)CarColors.Blue;
            //finalColor = Color.FromArgb(color_r, color_g, color_b);
            //Creates unique colors from RGB color codes
            this.CarColor = new Dictionary<Car.CarColors, int>
            {
                {CarColors.Red, 0},
                {CarColors.Green, 155},
                {CarColors.Blue, 137}
            };




        }

        //    (Axle Ratio x v x Transmission Ratio x 336.13) / Tire Diameter ] =  [(3.73 x 65 x 1.00 x 336.13) / 31 ] = [2628]
        //Note: 336.13 is used to convert the result to RPM = [63360 inches per mile / (60 minutes per hour x Pi.)]
        public void Checkspeed(int size)
        {
            double v = 0.00595 * (1000 * size);
            var temp_speed = v;

            var rpm = ((3.73 * v * 1 * 336.13) / size);

            this.Speed = 0.00595 * (rpm * size);
        }

        //Detects in-game impact
        public void DetectImpact()
        {
              hit = true;
        }
        //Rough estimate on car damage
        //Can be adjusted
        public void Setdamage(double speed, int health)
        {
            if(speed<=10 && hit == true){health -= 5;}
            else if(speed <=30  && hit == true){ health -=15; }
            else if (speed <= 60 && hit == true) { health -= 40; }
            else if (speed <= 100 && hit == true) { health -= 70; }
            else if (speed > 100 && hit == true) { health -= 100; }
        }

        //Checks car health in order check if the car still has health points , if not car stops.
        public void Checkhealth(int armor, int health)
        {
            if(armor <= 0 && health == 0)
            {
                Speed = 0;
            }
            
        }
    }

       
}


    

