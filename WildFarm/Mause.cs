using System;

namespace WildFarm
{
    public class Mause : Mammal
    {
        public Mause(string name, double weight, int foodEaten, string livingRegion)
            : base(name, weight, foodEaten, livingRegion)
        {

        }

        public void AskForFood()
        {
            Console.WriteLine("Squeak");
        }

        public override void Feed(string foodType, int quantity)
        {

            if (foodType == "Vegetable" || foodType == "Fruit")
            {
                double getFat = quantity * 0.10;
                Weight += getFat;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Mouse does not eat {foodType}!");
            }

        }

        public override string ToString()
        {
            return $"Mouse [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
