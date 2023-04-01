using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private string _askForFoodSound;
        private List<string> foodTypes;
        public Animal(string name, double weight, string sound, string[] foodTypesOFAnimal, double weightMultiplier)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
            _askForFoodSound = sound;
            foodTypes = new List<string>(foodTypesOFAnimal);
            WeightMultiplier = weightMultiplier;
        }
        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public double WeightMultiplier { get; private set; }    

        public bool CheckIfEatFood(IFood food)
        {
            return foodTypes.Contains(food.GetType().Name);
        }
        public string Eat(Interfaces.IFood food)
        {
            if (!CheckIfEatFood(food))
            {
                return $"{_askForFoodSound}{Environment.NewLine}{this.GetType().Name} does not eat {food.GetType().Name}!";
            }
            Weight += food.Quantity * WeightMultiplier;
            FoodEaten += food.Quantity;
            return _askForFoodSound;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
