using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        private const string _askForFoodSound = "ROAR!!!";
        private static readonly string[] foodTypes = { "Meat" };
        private const double weightMultiplier = 1;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed, _askForFoodSound, foodTypes, weightMultiplier)
        {
        }
    }
}
