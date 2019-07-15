using System;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {

        }

        public void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Feed(string foodType, int quantity)
        {
            if (foodType == "Meat")
            {
                double getFat = quantity * 0.25d;
                Weight += getFat;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Own does not eat {foodType}");
            }
        }

        public override string ToString()
        {
            return $"Own [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
