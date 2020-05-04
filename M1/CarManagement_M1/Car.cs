using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarManagement_M1
    
{
    public class Car
    {
        
        public int Armor { get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public int Health { get; set; }
        public float Speed { get; set; }

        public Car(int armor, string make, string model, Color color, int health, float speed)
        {
            this.Armor = armor;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Health = health;
            this.Speed = speed;
        }

       
    }
}

    

