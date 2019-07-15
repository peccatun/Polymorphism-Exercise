using System;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, int foodEaten, string livingRegion)
            : base(name, weight, foodEaten, livingRegion)
        {

        }

        public void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public override void Feed(string foodType, int quantity)
        {

            if (foodType == "Meat")
            {
                double getFat = quantity * 0.40d;
                Weight += getFat;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Dog does not eat {foodType}!");
            }
        }
        public override string ToString()
        {
            return $"Dog [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
