using PizzaCalories.Common;
using PizzaCalories.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public class Dough
    {

        private const double CALORIES_PER_GRAM = 2.00;
        private const double MINIMUM = 0;
        private const double MAXIMIUM = 200;


        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType { get; set; }

        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            set
            {
                if (!Modifiers.Modifier.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidTypeOfDoughMessage));
                }
                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < MINIMUM || value > MAXIMIUM)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidWeightOfDoughMessage));
                }
                this.weight = value;
            }
        }

        public double Calories => CalculateCalories();
        private double CalculateCalories()
        {
            double calories = CALORIES_PER_GRAM * Weight * Modifiers.Modifier[FlourType.ToLower()] * Modifiers.Modifier[BakingTechnique.ToLower()];
            return calories;
        }

    }
}
