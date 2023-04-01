﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity)
        {
        }

        public int Quantity { get; protected set; }
    }
}
