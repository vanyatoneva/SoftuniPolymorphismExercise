using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Mammal : Animal, IMammal
    {
        public Mammal(string name, double weight, string livingRegion, string sound, string[] foodTypesOFAnimal, double weightMultiplier) 
            : base(name, weight, sound, foodTypesOFAnimal, weightMultiplier)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion {get; protected set;}

        public override string ToString()
        {
            return $"{base.ToString()}{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
