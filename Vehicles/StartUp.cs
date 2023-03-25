

using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IEngine engine = new Engine(writer, reader);

engine.Run();