
namespace Vehicles
{
    public interface IVihicle
    {
        double FuelQuantity { get;}
        double FuelConsumption { get;}
        double TankCapacity { get; }

        bool Drive(double distance);
        void Refuel(double fuelAmount);
    }
}
