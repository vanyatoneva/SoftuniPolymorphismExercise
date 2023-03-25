using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Factories.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string[] vehicleInfo)
        {
            IVehicle vehicle = null;
            if (vehicleInfo[0] == "Car")
            {
                vehicle = new Car(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]));
            }
            else if(vehicleInfo[0] == "Truck")
            {
                vehicle = new Truck(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]));
            }
            return vehicle;
        }
    }
}
