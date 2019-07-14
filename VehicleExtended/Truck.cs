using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVihicle
    {
        private const double AIR_CONDUCT_CONSUMP = 1.6d;
        private const double FUEL_LOST_FROM_HOLE = 0.95d;

        private double fuelQuantity;

        public Truck(double quantity, double consump, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = quantity;
            FuelConsumption = consump;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            private set
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; set; }

        public bool Drive(double distance)
        {
            bool hasDriven = true;
            double allConsump = FuelConsumption + AIR_CONDUCT_CONSUMP;
            double fuelNeeded = (allConsump * distance);

            if (FuelQuantity - fuelNeeded < 0)
            {
                hasDriven = false;
            }
            if (FuelQuantity - fuelNeeded >= 0)
            {
                FuelQuantity -= fuelNeeded;
            }

            return hasDriven;
        }

        public void Refuel(double fuelAmount)
        {
            double firstAmount = fuelAmount;
            fuelAmount *= FUEL_LOST_FROM_HOLE;
            if (FuelQuantity + fuelAmount > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {firstAmount} fuel in the tank");
                return;
            }
            else if (fuelAmount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            FuelQuantity += fuelAmount;
        }
    }
}
