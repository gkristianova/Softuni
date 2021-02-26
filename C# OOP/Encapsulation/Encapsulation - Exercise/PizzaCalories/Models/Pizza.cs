using PizzaCalories.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private ICollection<Topping> toppings;

        private Pizza()
        {
            this.toppings = new List<Topping>();
        }
        public Pizza(string name, Dough dough)
            : this()
        {
            Name = name;
            this.dough = dough;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidPizzaNameMessage));
                }
                name = value;
            }
        }

        public string Dough { get; private set; }

        public string Topping { get; private set; }

        public double PizzaCalories => dough.Calories + toppings.Sum(x => x.Calories);

        public void AddToppings(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InvalidToppingsNumberMessage));
            }
            toppings.Add(topping);
        }
        public override string ToString()
        {
            return $"{Name} - {PizzaCalories:f2} Calories.";
        }
    }
}
