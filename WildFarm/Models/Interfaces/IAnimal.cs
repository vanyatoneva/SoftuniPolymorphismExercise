using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models.Interfaces
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        public int FoodEaten { get; }

        public double WeightMultiplier { get; }

        public bool CheckIfEatFood(IFood food);
        public string Eat(IFood food);
    }
}
