

using Raiding.Core;
using Raiding.Core.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

IWriter writer = new ConsoleWriter();
IReader reader = new ConsoleReader();
IEngine engine = new Engine(writer, reader);

engine.Run();