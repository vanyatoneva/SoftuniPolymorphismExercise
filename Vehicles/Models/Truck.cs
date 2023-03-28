using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double conditionerFuelConsumption = 1.6;
        private const double fuelReductionPercent = 5;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }
        protected override double ConditionerFuelConsumption => conditionerFuelConsumption;

        public override void Refuel(double litres)
        {
            CheckFuel(litres);
            FuelQuantity += (litres * (1 - (fuelReductionPercent * 0.01)));
            if(FuelQuantity > TankCapacity)
            {
                FuelQuantity = TankCapacity;
            }
        }
           // => FuelQuantity += (litres * (1 - (fuelReductionPercent * 0.01)));
    }
}
