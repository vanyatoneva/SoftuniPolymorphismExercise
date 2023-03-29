using Raiding.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models.Interfaces
{
    public interface IBaseHero
    {
        public string Name { get; protected set; }
        public int Power { get; protected set; }
        
        public string CastAbility();
    }
}
