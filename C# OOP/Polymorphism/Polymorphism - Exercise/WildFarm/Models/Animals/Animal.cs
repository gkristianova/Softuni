using System;
using System.Collections.Generic;
using WildFarm.Exceptions;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private const string UneatableFoodMessage = "{0} does not eat {1}!";
        string name;
        double weight;
        int foodEaten;

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            
            
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PreferredFoods { get; }

        public abstract string ProduceSound();
        public void Feed(IFood food)
        {
            if (!PreferredFoods.Contains(food.GetType()))
            {
                throw new UneatableFoodException(String.Format(UneatableFoodMessage, GetType().Name, food.GetType().Name));
            }
            Weight += WeightMultiplier * food.Quantity;
            FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
