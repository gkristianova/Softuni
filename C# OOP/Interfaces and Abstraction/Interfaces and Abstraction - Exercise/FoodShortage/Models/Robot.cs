

using FoodShortage.Models.Contracts;

namespace FoodShortage.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get; set; }
        public string Id { get; set; }
        public override string ToString() => $"{Id}";
    }
}
