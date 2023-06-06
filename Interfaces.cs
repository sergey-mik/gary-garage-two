namespace Garage
{
    public interface IElectricVehicle
    {
        int CurrentChargePercentage { get; }
        void ChargeBattery();
    }
    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; }
        void RefuelTank();
    }
}