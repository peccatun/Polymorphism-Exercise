using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : IVihicle
    {
        private const double AIR_CONDICT_CONSUMP = 1.4d;

        private double fuelQuantity;

        public Bus(double fuelQuantity, double consumption, double capacity)
        {
            TankCapacity = capacity;
            FuelConsumption = consumption;
            FuelQuantity = fuelQuantity;
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

            double fuelNeeded = FuelConsumption * distance;

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

        public bool DriveWithPassangers(double distance)
        {
            bool hasDriven = true;

            double fuelNeeded = (FuelConsumption + AIR_CONDICT_CONSUMP) * distance;

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
