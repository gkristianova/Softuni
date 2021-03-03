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
        private double tankCapacity;
        


        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity <= tankCapacity)
            {
                FuelQuantity = fuelQuantity;
            }
            else
            {
                FuelQuantity = 0;
            }
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            
        }

        public double FuelQuantity { get; set; }
        protected double FuelConsumption { get;  }

        protected double TankCapacity { get; set; }
        protected abstract double AirConditionConsumption { get;  }
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
            if (litres <= 0 )
            {
                Console.WriteLine(String.Format(GlobalConstants.FUEL_MUST_BE_POSITIVE_NUMBER));
            }
            else
            {
                if (HasProblem)
                {
                    double addedFuel = litres * FUEL_LOSS_PERCENT;
                    CheckTankCapacity(litres, addedFuel);

                }
                else
                {
                    double addedFuel = litres;
                    CheckTankCapacity(litres, addedFuel);
                }
            }
           
        }

        private void CheckTankCapacity(double litres, double addedFuel)
        {
            if (FuelQuantity + addedFuel <= TankCapacity)
            {
                FuelQuantity += addedFuel;
            }
            else
            {
                Console.WriteLine(String.Format(GlobalConstants.OVERFILL_TANK, litres));
            }
        }

        public override string ToString() => $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        
    }
}
