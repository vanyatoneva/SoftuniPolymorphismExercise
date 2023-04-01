using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const string _askForFoodSound = "Hoot Hoot";
        private static readonly string[] foodTypes = { "Meat" };
        private const double weightMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, _askForFoodSound, wingSize, foodTypes, weightMultiplier)
        {
        }
    }
}
