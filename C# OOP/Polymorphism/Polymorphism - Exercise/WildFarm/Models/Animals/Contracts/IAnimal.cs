using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animals.Contracts
{
    interface IAnimal
    {
        public string Name { get; }

        public double Weight { get;  }

        public int FoodEaten { get;  }

        string ProduceSound();

        void Feed(IFood food);
    }
}
