using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const string _askForFoodSound = "Woof!";
        private static readonly string[] foodTypes = { "Meat" };
        private const double weightMultiplier = 0.4;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion, _askForFoodSound, foodTypes, weightMultiplier)
        {
        }
    }
}
