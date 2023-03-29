using Raiding.Factories.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factories
{
    public  class HeroFactory : IHeroFactory
    {
        public  IBaseHero CreateHero(string name, string type)
        {
            IBaseHero baseHero = null;
            if (type == "Druid")
            {
                baseHero = new Druid(name);
            }
            else if(type == "Paladin")
            {
                baseHero = new Paladin(name);
            }
            else if(type == "Rogue")
            {
                baseHero = new Rogue(name);
            }
            else if(type == "Warrior")
            {
                baseHero = new Warrior(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }
            return baseHero;
        }
    }
}
