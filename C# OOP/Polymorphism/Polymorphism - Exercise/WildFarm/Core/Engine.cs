using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Core.Contracts;
using WildFarm.Exceptions;
using WildFarm.Factories;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;
        private FoodFactory foodFactory;
        public Engine()
        {
            animals = new List<IAnimal>();
            foodFactory = new FoodFactory(); 
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] foodArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                IAnimal animal = CreateAnimal(animalArgs);
                IFood food = foodFactory.ProduceFood(foodArgs[0], int.Parse(foodArgs[1]));
                animals.Add(animal);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Feed(food);
                }
                catch (UneatableFoodException ufe)
                {

                    Console.WriteLine(ufe.Message);
                }


            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }


        }

        private static IAnimal CreateAnimal(string[] animalArgs)
        {
            IAnimal animal = null;

            string animalType = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            if (animalType == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (animalType == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else
            {
                string livingRegion = animalArgs[3];
                if (animalType == "Dog")
                {
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    string breed = animalArgs[4];
                    if (animalType == "Cat")
                    {
                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                }

            }

            return animal;
        }
    }
}
