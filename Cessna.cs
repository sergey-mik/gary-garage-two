using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // propeller light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 75;

        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("The White Cessna flashes by you lika a hurricane.Zzoooooommmmmm");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The white Cessna carefully turns {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The Cessna rolls down the runway for a mile and stops.");
        }
    }
}