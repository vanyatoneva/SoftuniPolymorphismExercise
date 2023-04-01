using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.IO.Interfaces;

namespace Vehicles.IO
{
    public class FileWriter : IWriter
    {

        public FileWriter(string path)
        {
            Path = path;
        }

        public string Path { get; private set; }
        public void Write(string args)
        {
            using(StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(args);
            }
        }

        public void WriteLine(string args)
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine(args);
            }
        }
    }
}
