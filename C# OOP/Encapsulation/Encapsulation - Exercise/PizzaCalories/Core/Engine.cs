using System;
using System.Linq;
using PizzaCalories.Models;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Core
{
    class Engine
    {
        public void Run()
        {
            string[] pizzaData = Console.ReadLine()
            .Split()
            .ToArray(); 


            string[] doughData = Console.ReadLine()
            .Split()
            .ToArray(); 

            Dough dough = CreateDough(doughData);
            Pizza pizza = CreatePizza(pizzaData, dough);
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {

                string[] toppingData = input.Split().ToArray();
                Topping topping = CreateTopping(toppingData);
                pizza.AddToppings(topping);
            }
            Console.WriteLine(pizza);
        }
        
        private Pizza CreatePizza(string[] pizzaData, Dough dough)
        {
            string nameOfPizza = pizzaData[1];
            Pizza pizza = new Pizza(nameOfPizza, dough);
            return pizza;
        }
        private Dough CreateDough(string[] doughData)
        {
            string typeOfDough = doughData[1];
            string technique = doughData[2];
            double weight = double.Parse(doughData[3]);
            Dough dough = new Dough(typeOfDough, technique, weight);
            return dough;
        }
        private Topping CreateTopping(string[] toppingData)
        {
            string type = toppingData[1];
            double weight = double.Parse(toppingData[2]);
            Topping topping = new Topping(type, weight);
            return topping;
        }
    }
    
}
