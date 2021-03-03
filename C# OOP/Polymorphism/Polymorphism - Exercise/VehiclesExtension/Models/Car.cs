using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 0.9;
        private const bool hasProblem = false;
        public Car(double fuelQuantity, double fuelConsumtpion, double tankCapacity)
            : base(fuelQuantity, fuelConsumtpion, tankCapacity)
        {

        }

        protected override double AirConditionConsumption => AIR_CONDITION_CONSUMPTION;

        protected override bool HasProblem => hasProblem;
    }
}
