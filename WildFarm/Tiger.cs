using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {

        }

        public void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void Feed(string foodType, int quantity)
        {

            if (foodType == "Meat")
            {
                double getFat = quantity * 1d;
                Weight += getFat;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {foodType}!");
            }

        }
        public override string ToString()
        {
            return $"Tiger [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
