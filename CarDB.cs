using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProj_Shimon
{
    class CarDB
    {
        private Dictionary<string, Car> cars = new Dictionary<string, Car>();

        public void AddCar(string key, Car car) => this.cars.Add(key, car);

        public void DeleteCar(string key) => this.cars.Remove(key);

        public Car GetCar(string key)
        {
            if (this.cars.ContainsKey(key))
            {
                return this.cars[key];
            }
            else
                return null;
        }

        public void UpdateCar(string key, Car car) => this.cars[key] = car;

    }


}
