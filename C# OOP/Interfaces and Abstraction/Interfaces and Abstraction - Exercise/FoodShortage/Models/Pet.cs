using FoodShortage.Models.Contracts;


namespace FoodShortage.Models
{
    public class Pet : IBirthday
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public string Birthdate { get; set; }

        public override string ToString() => $"{Birthdate}";
    }
}
