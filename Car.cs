using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVihicle
    {
        private const double AIR_CONDIT_CONSUMP = 0.9d;

        public Car(double quantity,double consumption)
        {
            FuelQuantity = quantity;
            FuelConsumption = consumption;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }

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
            FuelQuantity += fuelAmount;
        }
    }
}
