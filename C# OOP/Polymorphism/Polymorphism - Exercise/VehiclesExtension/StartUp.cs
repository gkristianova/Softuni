using System;
using System.Linq;
using VehiclesExtension.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = ConsoleRead();
            string[] truckInfo = ConsoleRead();
            string[] busInfo = ConsoleRead();

            Car car = CreateCar(carInfo);
            Truck truck = CreateTruck(truckInfo);
            Bus bus = CreateBus(busInfo);

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
                            case "Bus":
                                bus.Drive(distance);
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
                            case "Bus":
                                bus.Refuel(litres);
                                break;
                        }
                        break;
                    case "DriveEmpty":
                        
                        bus.DriveEmpty(distance);
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }

        private static Bus CreateBus(string[] busInfo)
        {
            double fuelQuantity = double.Parse(busInfo[1]);
            double fuelConsumption = double.Parse(busInfo[2]);
            double tankCapacity = double.Parse(busInfo[3]);
            return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
        }

        private static Truck CreateTruck(string[] truckInfo)
        {
            double fuelQuantity = double.Parse(truckInfo[1]);
            double fuelConsumption = double.Parse(truckInfo[2]);
            double tankCapacity = double.Parse(truckInfo[3]);
            return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
        }

        private static Car CreateCar(string[] carInfo)
        {
            double fuelQuantity = double.Parse(carInfo[1]);
            double fuelConsumption = double.Parse(carInfo[2]);
            double tankCapacity = double.Parse(carInfo[3]);
            return new Car(fuelQuantity, fuelConsumption, tankCapacity);
        }

        private static string[] ConsoleRead()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}
