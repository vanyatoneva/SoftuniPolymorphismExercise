﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int power = 80;
        public Rogue(string name) : base(name)
        {
            Power = power;
            _powerType = Enums.HeroPowerType.hit;
        }

        public override string CastAbility()
        {
            return $"{base.CastAbility()} damage";
        }
    }
}
