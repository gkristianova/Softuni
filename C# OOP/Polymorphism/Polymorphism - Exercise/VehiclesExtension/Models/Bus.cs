using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        
        private const bool hasProblem = false;
       
        private double airCondConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumtpion, double tankCapacity)
            : base(fuelQuantity, fuelConsumtpion, tankCapacity)
        {

        }

        protected override double AirConditionConsumption => airCondConsumption;
        

        protected override bool HasProblem => hasProblem;

        public void DriveEmpty(double distance)
        {
            double fuelAfterDrive = FuelQuantity - distance * FuelConsumption;
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
    }
}
