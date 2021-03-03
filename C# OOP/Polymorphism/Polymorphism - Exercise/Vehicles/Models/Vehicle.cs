using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private const double FUEL_LOSS_PERCENT = 0.95;
       
        private double fuelQuantity;
        private double fuelConsumption;
        


        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        protected abstract double AirConditionConsumption { get; }
        protected abstract bool HasProblem { get; }

        public virtual void Drive(double distance) 
        {
            double fuelAfterDrive = FuelQuantity - distance * (FuelConsumption + AirConditionConsumption);
            if (fuelAfterDrive < 0)
            {
                 Console.WriteLine(String.Format(GlobalConstants.NEED_REFUELING, GetType().Name, distance)); 
            }
            else
            {
                FuelQuantity = fuelAfterDrive;
                Console.WriteLine(String.Format(GlobalConstants.TRAVELED_DISTANCE, GetType().Name, distance)); 
            }
        }
        public virtual void Refuel(double litres)
        {
            if (HasProblem)
            {
                FuelQuantity += litres * FUEL_LOSS_PERCENT;
            }
            else
            {
                FuelQuantity += litres;
            }
        }

        public override string ToString() => $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
