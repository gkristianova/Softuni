using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree.Core
{
    class Engine
    {
        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;
        public Engine()
        {
            people = new List<Person>();
            products = new List<Product>();
           
        }

        public void Run()
        {
            string[] people = ConsoleRead();
            string[] product = ConsoleRead();
            foreach (var item in people)
            {
               
                AddPerson(item);
               
            }
            foreach (var item in product)
            {
              
                AddProduct(item);
             
            }
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string nameOfPerson = data[0];
                string nameOfProduct = data[1];
                Person person = GetPerson(nameOfPerson);
                Product prod = GetProduct(nameOfProduct);
                if (person != null && prod != null)
                {
                    person.AddProduct(prod);
                }

            }
            foreach (var item in this.people)
            {
                Console.WriteLine(item);
            }
        }

        private string[] ConsoleRead() => Console.ReadLine()
            .Split(";", StringSplitOptions.RemoveEmptyEntries);

        private void AddPerson(string people)
        {
            string[] data = people.Split("=", StringSplitOptions.RemoveEmptyEntries);
            string personName = data[0];
            decimal money = decimal.Parse(data[1]);
            Person person = new Person(personName, money);
            this.people.Add(person);
        }
        private void AddProduct(string prodArr)
        {
            string[] data = prodArr.Split("=", StringSplitOptions.RemoveEmptyEntries);
            string productName = data[0];
            decimal cost = decimal.Parse(data[1]);
            Product product = new Product(productName, cost);
            products.Add(product);
        }
        private Person GetPerson(string name) => people.FirstOrDefault(x => x.Name == name);
        private Product GetProduct(string nameOfProduct) => products.FirstOrDefault(x => x.Name == nameOfProduct);
    }
}
