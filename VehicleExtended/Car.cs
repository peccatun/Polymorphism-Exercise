using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVihicle
    {
        private const double AIR_CONDIT_CONSUMP = 0.9d;

        private double fuelQuantity;

        public Car(double quantity,double consumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = quantity;
            FuelConsumption = consumption;
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

        public double TankCapacity { get; private set; }

        public bool Drive(double distance)
        {
            bool hasDriven = true;
            double allConsum = FuelConsumption + AIR_CONDIT_CONSUMP;
            double fuelNeeded = (allConsum * distance);

            if (FuelQuantity - fuelNeeded < 0 )
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
            if (FuelQuantity + fuelAmount > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
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
