using BorderControl.Models;
using BorderControl.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<IIdentifiable> idList = new List<IIdentifiable>();
            while ((input = Console.ReadLine()) != "End")
            {
                var data = input.Split();
                var nameOrModel = data[0];
                if (data.Length == 3)
                {
                    var age = int.Parse(data[1]);
                    var id = data[2];
                    IIdentifiable citizen = new Citizen(nameOrModel, age, id);
                    idList.Add(citizen);
                }
                else
                {
                    var id = data[1];
                    IIdentifiable robot = new Robot(nameOrModel, id);
                    idList.Add(robot);
                }
            }
            string specificDigits = Console.ReadLine();
            idList = idList.Where(x => x.Id.EndsWith(specificDigits)).ToList();
            idList.ForEach(Console.WriteLine);
        }
    }
}
