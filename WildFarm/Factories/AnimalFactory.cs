using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] animalInfo)
        {
            //IAnimal animal = null;
            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);
            string livingRegion = animalInfo[3]; //Pnly for birds is different, parsed in owl and hen's cases
            switch (type)
            {
                case "Owl":
                    {
                        double wingSize = double.Parse(animalInfo[3]);
                        return new Owl(name, weight, wingSize);
                    }
                case "Hen":
                    {
                        double wingSize = double.Parse(animalInfo[3]);
                        return new Hen(name, weight, wingSize);
                    }
                case "Tiger":
                    return new Tiger(name, weight, livingRegion, animalInfo[4]);
                case "Mouse":
                    return new Mouse(name, weight, livingRegion);
                case "Dog":
                    return new Dog(name, weight, livingRegion);
                case "Cat":
                    return new Cat(name, weight, livingRegion, animalInfo[4]);
                    default:
                    return null;

            }
            //return animal;
        }
    }
}
