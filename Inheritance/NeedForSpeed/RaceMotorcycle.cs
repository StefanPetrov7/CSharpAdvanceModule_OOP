﻿using System;
namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double defaultFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
        {
            get { return defaultFuelConsumption; }
        }

        public override void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
