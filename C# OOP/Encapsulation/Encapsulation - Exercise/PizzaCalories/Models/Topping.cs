using System;
using PizzaCalories.Common;
using PizzaCalories.Exceptions;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public class Topping
    {
        
        private const double CALORIES_PER_GRAM = 2.00;
        private const double MINIMUM = 0;
        private const double MAXIMUM = 50;

        private string typeOfMeat;
        private double weight;
        public Topping(string typeOfMeat, double weight)
        {
            this.TypeOfMeat = typeOfMeat;
            this.Weight = weight;
        }
        public string TypeOfMeat
        {
            get
            {
                return this.typeOfMeat;
            }
            set
            {
                if (!Modifiers.Modifier.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.CannotPlaceToppingMessage, value));
                }
                this.typeOfMeat = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < MINIMUM || value > MAXIMUM)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidToppingWeight,TypeOfMeat));
                }
                this.weight = value;
            }
        }
        public double Calories => CalculateCalories();
        private double CalculateCalories()
        {
            double totalCalories = CALORIES_PER_GRAM * this.Weight * Modifiers.Modifier[this.TypeOfMeat.ToLower()];
            return totalCalories;
        }
    }
}
