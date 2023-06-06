using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 100;

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("The Burgundy Tesla blazzes by you. MMmmmmmmmmmmmmm");
        }
    }
}