using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const string _askForFoodSound = "Cluck";
        private static readonly string[] foodTypes = { "Meat", "Vegetable", "Seeds", "Fruit" };
        private const double weightMultiplier = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight,  _askForFoodSound, wingSize, foodTypes, weightMultiplier)
        {
        }
    }
}
