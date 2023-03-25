using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;  
        }
        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        protected virtual double ConditionerFuelConsumption { get; }

        public string Drive(double distance)
        {
            double neededFuel = distance * (FuelConsumption + ConditionerFuelConsumption);
            if(neededFuel > FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            FuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double litres)
            => FuelQuantity += litres;

        public override string ToString()
            => $"{this.GetType().Name}: {FuelQuantity:f2}";
            
    }
}
