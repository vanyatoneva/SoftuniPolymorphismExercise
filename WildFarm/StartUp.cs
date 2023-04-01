
using Vehicles.IO;
using Vehicles.IO.Interfaces;
using WildFarm.Core;
using WildFarm.Core.Interfaces;

IWriter writer = new ConsoleWriter();
IReader reader = new ConsoleReader();
IEngine engine = new Engine(writer, reader);
engine.Run();