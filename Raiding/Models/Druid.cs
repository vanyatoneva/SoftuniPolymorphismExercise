using Raiding.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int power = 80;
        private const HeroPowerType powerType = HeroPowerType.healed;
        public Druid(string name) : base(name)
        {
            Power = power;
            _powerType = powerType;
        }
    }
}
