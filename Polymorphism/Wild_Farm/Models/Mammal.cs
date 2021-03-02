﻿namespace Wild_Farm.Models
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; }

        public override string ToString()
        {
            return base.ToString() + $"{ this.Weight}, { this.LivingRegion}, { this.FoodEaten}]";
        }
    }
}
