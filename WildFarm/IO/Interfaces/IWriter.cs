using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.IO.Interfaces
{
    public interface IWriter
    {
        public void Write(string args);

        public void WriteLine(string args);
    }
}
