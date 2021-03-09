using BorderControl.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public override string ToString() => $"{Id}";
    }
}
