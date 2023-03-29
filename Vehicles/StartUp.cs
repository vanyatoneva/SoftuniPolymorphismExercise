

using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
//IReader reader = new FileReader($"../../../input.txt");
//IWriter writer = new FileWriter($"../../../output.txt");
IEngine engine = new Engine(writer, reader);

engine.Run();