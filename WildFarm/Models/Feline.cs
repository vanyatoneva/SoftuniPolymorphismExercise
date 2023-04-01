using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Feline : Mammal, IFeline
    {
        public Feline(string name, double weight, string livingRegion, string breed, string sound,  string[] foodTypesOFAnimal, double weightMultiplier) 
            : base(name, weight,  livingRegion, sound, foodTypesOFAnimal, weightMultiplier)
        {
            Breed = breed;
        }

        public string Breed {get; protected set;}

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
