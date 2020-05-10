using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement_M1
{
    public class CarDatabase : Car
    {
        private List<Car> cars = new List<Car>();

        public void BuildCarDatabase()
        {
            cars.Add(new Car(100, 0, 0, new Dictionary<Car.CarColors, int>
            {
                {Car.CarColors.Red, 0},
                {Car.CarColors.Green, 0},
                {Car.CarColors.Blue, 0}
            }, 100, 0));
            cars.Add(new Tires(100,50, Tires.TireTypes.Drag));

            cars.Add(new Rim(16, new Dictionary<Rim.RimColors, int>
            {
                {Rim.RimColors.Red, 0},
                {Rim.RimColors.Green, 0},
                {Rim.RimColors.Blue, 0}
            },Rim.RimTypes.Sport));

            cars.Add(new Storage(50, Storage.CarTypes.SUV));
        }

        public List<Car> Database()
        {
            return cars;
        }
    }

}
