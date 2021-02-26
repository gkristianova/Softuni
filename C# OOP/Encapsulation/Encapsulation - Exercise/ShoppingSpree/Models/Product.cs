using System;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name

        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }


        public decimal Cost
        {
            get
            {
                return cost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");


                    
                }
                cost = value;
            }
        }

        public override string ToString() => $"{Name}";
    }
}
