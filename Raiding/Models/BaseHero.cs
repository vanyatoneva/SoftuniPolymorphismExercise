using Raiding.Models.Enums;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseHero
    {
        protected HeroPowerType _powerType; 
        public string Name { get; set; }    
        public virtual int Power { get; set; }

        public BaseHero(string name)
        {
            Name = name;
        }
        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} {_powerType} for {Power}";
        }
    }
}
