using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    class Cat : Feline
    {
        private const double WEIGHT_MULTIPLIER = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }
        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Meat), typeof(Vegetable) };

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
