using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.IO.Interfaces;

namespace Vehicles.IO
{
    public class FileReader : IReader
    {
        public FileReader(string path)
        {
            Path = path;
        }
        public string Path { get; private set; }

        public string ReadLine()
        {
            using (StreamReader sr =  new StreamReader(Path))
            {
                return sr.ReadLine();
            }
        }
    }
}
