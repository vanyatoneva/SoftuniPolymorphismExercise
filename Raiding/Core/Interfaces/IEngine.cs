using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.IO.Interfaces;

namespace Raiding.Core.Interfaces
{
    public interface IEngine
    {
        public IWriter Writer { get;  }
        public IReader Reader { get;  }
        public void Run();
    }
}
