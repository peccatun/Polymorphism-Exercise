using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carInformation = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carInformation[1]), double.Parse(carInformation[2]));

            string[] truckInformation = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]));

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] playersMoves = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = playersMoves[0];
                string moveObject = playersMoves[1];
                double parametter = double.Parse(playersMoves[2]);

                if (command == "Drive")
                {
                    if (moveObject == "Car")
                    {
                        if (car.Drive(parametter))
                        {
                            Console.WriteLine($"Car travelled {parametter} km");
                        }
                        else
                        {
                            Console.WriteLine($"Car needs refueling");
                        }
                    }
                    else if (moveObject == "Truck")
                    {
                        if (truck.Drive(parametter))
                        {
                            Console.WriteLine($"Truck travelled {parametter} km");
                        }
                        else
                        {
                            Console.WriteLine($"Truck needs refueling");
                        }
                    }
                }
                else if (command == "Refuel")
                {
                    if (moveObject == "Car")
                    {
                        car.Refuel(parametter);
                    }
                    else if (moveObject == "Truck")
                    {
                        truck.Refuel(parametter);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
