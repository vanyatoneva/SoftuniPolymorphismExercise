using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const string _askForFoodSound = "Meow";
        private static readonly string[] foodTypes = { "Meat", "Vegetable" };
        private const double weightMultiplier = 0.3;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed, _askForFoodSound, foodTypes, weightMultiplier)
        {
        }
    }
}
