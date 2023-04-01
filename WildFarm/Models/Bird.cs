using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Bird : Animal, IBird
    {
        public Bird(string name, double weight, string sound, double wingSize, string[] foodTypesOFAnimal, double weightMultiplier) 
            : base(name, weight, sound, foodTypesOFAnimal, weightMultiplier)
        {
            WingSize = wingSize;
        }

        public double WingSize {get; protected set;}

        public override string ToString()
        {
            return $"{base.ToString()}{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
