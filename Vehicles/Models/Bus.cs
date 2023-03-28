using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Bus : Vehicle, IBus
    {
        private const double conditionerFuelConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }
        protected override double ConditionerFuelConsumption => conditionerFuelConsumption;

        public string DriveEmpty(double distance)
        {
            double neededFuel = distance * FuelConsumption ;
            if (neededFuel > FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            FuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }
}
