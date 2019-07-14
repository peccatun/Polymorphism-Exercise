
namespace Vehicles
{
    public interface IVihicle
    {
        double FuelQuantity { get;}
        double FuelConsumption { get;}

        bool Drive(double distance);
        void Refuel(double fuelAmount);
    }
}
