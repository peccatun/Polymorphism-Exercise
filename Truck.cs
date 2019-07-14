using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVihicle
    {
        private const double AIR_CONDUCT_CONSUMP = 1.6d;
        private const double FUEL_LOST_FROM_HOLE = 0.95d;

        public Truck(double quantity, double consump)
        {
            FuelQuantity = quantity;
            FuelConsumption = consump;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

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
            fuelAmount *= FUEL_LOST_FROM_HOLE;
            FuelQuantity += fuelAmount;
        }
    }
}
