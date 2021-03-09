using FoodShortage.Models.Contracts;


namespace FoodShortage.Models
{
    public class Citizen : IIdentifiable, IBirthday, IAge, IBuyer
    {
        public const int STARTING_FOOD = 0;
        public const int CITIZEN_FOOD_INCREASE = 10;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Id = id;
            Age = age;
            Birthdate = birthdate;
            Food = STARTING_FOOD;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; }

        public void BuyFood()
        {
            Food += CITIZEN_FOOD_INCREASE;
        }

        public override string ToString() => $"{Birthdate}";
    }
}
