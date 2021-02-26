using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private  readonly List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;

            bag = new List<Product>();
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

        public decimal Money
        {
            get
            {
                return money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");

                }
                money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get => (IReadOnlyCollection<Product>)bag;
        }

        private bool IsBagEmpty() => Bag.Count == 0;
        public void AddProduct(Product product)
        {
            if (Money >= product.Cost)
            {
               Money -= product.Cost;
               bag.Add(product);
                Console.WriteLine("{0} bought {1}", Name, product.Name);
            }
            else
            {
                Console.WriteLine("{0} can't afford {1}", Name, product.Name);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (IsBagEmpty())
            {
                sb.Append($"{name} - {"Nothing bought"}");
            }
            else
            {
                sb.AppendLine($"{Name} - {string.Join(", ", this.Bag)}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
