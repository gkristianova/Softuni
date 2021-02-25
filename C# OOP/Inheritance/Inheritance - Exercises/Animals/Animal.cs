using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private const string ERROR_MESSAGE = "Invalid input!";
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;

            Age = age;

            Gender = gender;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                this.name = value;
            }
        }


        public int Age 
        { 
            get
            {
                return age;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException(ERROR_MESSAGE);

                }
                age = value;
            }
        }

        public string Gender 
        {
            get
            {
                return gender;
            }
            private set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }

                gender = value;
            }
        }

        public abstract string ProduceSound();
        

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{GetType().Name}");
            result.AppendLine($"{Name} {Age} {Gender}");
            result.AppendLine(ProduceSound());
            return result.ToString().TrimEnd();
        }
    }
}
