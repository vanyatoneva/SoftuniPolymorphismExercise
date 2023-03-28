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
        private double fuelQuantity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            
            FuelConsumption = fuelConsumption;  
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
        }
        public double FuelQuantity { 
            get => fuelQuantity;
            set
            {
                if(value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; protected set; }

        public double TankCapacity { get; private set; }
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
        // =>  FuelQuantity += litres;
        {
            CheckFuel(litres);
            FuelQuantity += litres;
            
        }

        protected void CheckFuel(double litres)
        {
            if (litres <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if(litres + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {litres} fuel in the tank");
            }
        }
        public override string ToString()
            => $"{this.GetType().Name}: {FuelQuantity:f2}";
            
    }
}
