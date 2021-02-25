using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumtpion = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }



        public virtual double FuelConsumption => DefaultFuelConsumtpion;

        public double Fuel { get; set; }
        public int HorsePower { get; set; }

       public  virtual void Drive(double km)
        {

            double leftFuel = Fuel - FuelConsumption * km;
            if (leftFuel >= 0)
            {
                Fuel = leftFuel;
            }
        }
    }
}
