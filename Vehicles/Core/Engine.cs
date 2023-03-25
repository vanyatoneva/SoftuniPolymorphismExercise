using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Interfaces;
using Vehicles.Factories;
using Vehicles.IO.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private VehicleFactory _vehicleFactory;
        private List<IVehicle> vehicles;
        public Engine(IWriter writer, IReader reader)
        {
            Writer = writer;
            Reader = reader;
            _vehicleFactory = new VehicleFactory();
            vehicles = new List<IVehicle>();
        }

        public IWriter Writer { get; private set; }
        public IReader Reader { get; private set; }

        
        public void Run()
        {
            string[] carInfos = Reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            vehicles.Add((Car)_vehicleFactory.CreateVehicle(carInfos));
            string[] truckInfo = Reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            vehicles.Add((Truck)_vehicleFactory.CreateVehicle(truckInfo));

            int commandCount = int.Parse(Reader.ReadLine());

            while(commandCount-- > 0)
            {
                string[] command = Reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == command[1]);
                if (command[0] == "Drive")
                {
                    Writer.WriteLine(vehicle.Drive(double.Parse(command[2])));
                }
                else if (command[0] == "Refuel")
                {
                    vehicle.Refuel(double.Parse(command[2]));
                }
            }

            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
