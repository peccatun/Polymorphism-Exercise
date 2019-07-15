//+src=Vegetable.cs
//+src=Tiger.cs
//+src=Seeds.cs
//+src=Owl.cs
//+src=Meat.cs
//+src=Mause.cs
//+src=Mammal.cs
//+src=Hen.cs
//+src=Fruid.cs
//+src=Food.cs
//+src=Feline.cs
//+src=Dog.cs
//+src=Cat.cs
//+src=Bird.cs
//+src=Animal.cs
using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            int i = 0;
            int animalToFeed = -1;
            List<Animal> animals = new List<Animal>();
            while ((command = Console.ReadLine()) != "End")
            {
                //Here we create animal
                if (i % 2 == 0)
                {
                    string[] animalInfo = command
                        .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    string type = animalInfo[0];
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);

                    if (type == "Owl")
                    {
                        Owl owl = new Owl(name,weight,0,double.Parse(animalInfo[3]));
                        owl.AskForFood();
                        animals.Add(owl);
                    }
                    else if (type == "Hen")
                    {
                        Hen hen = new Hen(name, weight, 0, double.Parse(animalInfo[3]));
                        hen.AskForFood();
                        animals.Add(hen);
                    }
                    else if (type == "Mouse")
                    {
                        Mause mause = new Mause(name,weight,0,animalInfo[3]);
                        mause.AskForFood();
                        animals.Add(mause);
                    }
                    else if (type == "Dog")
                    {
                        Dog dog = new Dog(name,weight,0,animalInfo[3]);
                        dog.AskForFood();
                        animals.Add(dog);
                    }
                    else if (type == "Cat")
                    {
                        Cat cat = new Cat(name,weight,0,animalInfo[3],animalInfo[4]);
                        cat.AskForFood();
                        animals.Add(cat);
                    }
                    else if (type == "Tiger")
                    {
                        Tiger tiger = new Tiger(name,weight,0,animalInfo[3],animalInfo[4]);
                        tiger.AskForFood();
                        animals.Add(tiger);
                    }
                    animalToFeed++;
                }
                //Create food and feed
                else
                {
                    string[] foodInfo = command
                        .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    string foodType = foodInfo[0];
                    int quantity = int.Parse(foodInfo[1]);

                    if (foodType == "Vegetable")
                    {
                        Vegetable vegetable = new Vegetable(quantity);
                        animals[animalToFeed].Feed(foodType, quantity);
                        
                    }
                    else if (foodType == "Fruit")
                    {
                        Fruid fruid = new Fruid(quantity);
                        animals[animalToFeed].Feed(foodType, quantity);
                    }
                    else if (foodType == "Meat")
                    {
                        Meat meat = new Meat(quantity);
                        animals[animalToFeed].Feed(foodType, quantity);
                    }
                    else if (foodType == "Seeds")
                    {
                        Seeds seeds = new Seeds(quantity);
                        animals[animalToFeed].Feed(foodType, quantity);
                    }
                }
                i++;
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
