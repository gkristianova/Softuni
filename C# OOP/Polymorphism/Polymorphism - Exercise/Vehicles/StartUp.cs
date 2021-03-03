using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = ConsoleRead();
            string[] truckInfo = ConsoleRead();
            Car car = CreateCar(carInfo);
            Truck truck = CreateTruck(truckInfo);


            int numberofCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberofCommands; i++)
            {
                string[] commandInfo = ConsoleRead();
                string command = commandInfo[0];
                double distance = double.Parse(commandInfo[2]);
                double litres = double.Parse(commandInfo[2]);
                string type = commandInfo[1];
                
                switch (command)
                {
                    case "Drive":
                        switch (type)
                        {
                            case "Car":
                                car.Drive(distance);
                                break;
                            case "Truck":
                                truck.Drive(distance);
                                break;
                        }
                        break;
                    case "Refuel":
                        switch (type)
                        {
                            case "Car":
                                car.Refuel(litres);
                                break;
                            case "Truck":
                                truck.Refuel(litres);
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);

        }

        private static Truck CreateTruck(string[] truckInfo)
        {
            double fuelQuantity = double.Parse(truckInfo[1]);
            double fuelConsumption = double.Parse(truckInfo[2]);
            return new Truck(fuelQuantity, fuelConsumption);
        }

        private static Car CreateCar(string[] carInfo)
        {
            double fuelQuantity = double.Parse(carInfo[1]);
            double fuelConsumption = double.Parse(carInfo[2]);
            return new Car(fuelQuantity, fuelConsumption);
        }

        private static string[] ConsoleRead()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}
