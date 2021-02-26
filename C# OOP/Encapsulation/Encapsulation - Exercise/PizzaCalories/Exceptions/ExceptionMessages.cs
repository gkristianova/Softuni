using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Exceptions
{
    public class ExceptionMessages
    {
        public static string InvalidTypeOfDoughMessage = "Invalid type of dough.";
        public static string InvalidWeightOfDoughMessage = "Dough weight should be in the range [1..200].";


        public static string InvalidPizzaNameMessage = "Pizza name should be between 1 and 15 symbols.";
        public static string InvalidToppingsNumberMessage = "Number of toppings should be in range [0..10].";

        public static string CannotPlaceToppingMessage = "Cannot place {0} on top of your pizza.";
        public static string InvalidToppingWeight = "{0} weight should be in the range [1..50].";
    }
}
