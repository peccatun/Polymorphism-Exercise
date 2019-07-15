using System;


namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten, wingSize)
        {

        }

        public void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void Feed(string foodType, int quantity)
        {

            double getFat = quantity * 0.35;

            Weight += getFat;
            FoodEaten += quantity;

        }

        public override string ToString()
        {
            return $"Hen [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
