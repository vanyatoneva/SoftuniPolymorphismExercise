using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const string _askForFoodSound = "Squeak";
        private static readonly string[] foodTypes = { "Vegetable", "Fruit" };
        private const double weightMultiplier = 0.1;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion, _askForFoodSound, foodTypes, weightMultiplier)
        {
        }
    }
}
