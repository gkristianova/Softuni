using FoodShortage.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    class Rebel : IAge, IGroup, IBuyer
    {
        public const int STARTING_FOOD = 0;
        public const int REBEL_FOOD_INCREASE = 5;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = STARTING_FOOD;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }
        public void BuyFood()
        {
            Food += REBEL_FOOD_INCREASE;
        }
    }
}
