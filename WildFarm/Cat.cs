using System;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {

        }

        public void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void Feed(string foodType, int quantity)
        { 
            if (foodType == "Meat" || foodType == "Vegetable")
            {
                double getFat = quantity * 0.30d;
                Weight += getFat;
                FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Cat does not eat {foodType}!");
            }
        }
        public override string ToString()
        {
            return $"Cat [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
