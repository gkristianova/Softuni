using FoodShortage.Models;
using FoodShortage.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<IBuyer> buyerList = new List<IBuyer>();
            for (int i = 0; i < n; i++)
            
            {
                var data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = data[0];
                int age = int.Parse(data[1]);


                if (data.Length == 4)
                {
                    IBuyer citizen = CreateCitizen(buyerList, data, name, age);
                    

                }
                else if (data.Length == 3)
                {
                    IBuyer rebel = CreateRebel(buyerList, data, name, age);
                    
                }

            }
            
            string input = string.Empty;
            int total = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var person in buyerList)
                {
                    if (person.Name == input)
                    {
                        person.BuyFood();
                        
                    }
                }
            }
            foreach (var person in buyerList)
            {
                total += person.Food;
            }

            Console.WriteLine(total);
        }

        private static IBuyer CreateRebel(List<IBuyer> buyerList, string[] data, string name, int age)
        {
            string group = data[2];
            IBuyer rebel = new Rebel(name, age, group);
            buyerList.Add(rebel);
            return rebel;
        }

        private static IBuyer CreateCitizen(List<IBuyer> buyerList, string[] data, string name, int age)
        {
            string id = data[2];
            string birthday = data[3];
            IBuyer citizen = new Citizen(name, age, id, birthday);
            buyerList.Add(citizen);
            return citizen;
        }

    }
}
