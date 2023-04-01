﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Food : Interfaces.IFood
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
