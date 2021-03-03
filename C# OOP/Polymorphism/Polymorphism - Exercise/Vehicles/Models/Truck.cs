using System;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 1.6;
        private const bool hasProblem = true;
        public Truck (double fuelQuantity, double fuelConsumtpion)
            : base(fuelQuantity, fuelConsumtpion)
        {

        }

        protected override double AirConditionConsumption => AIR_CONDITION_CONSUMPTION;

        protected override bool HasProblem => hasProblem;
    }
}
