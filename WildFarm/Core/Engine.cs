using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.IO.Interfaces;
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;
        private readonly ICollection<IAnimal> animals ;
        public Engine(IWriter writer, IReader reader)
        {
            Writer = writer;
            Reader = reader;
            animalFactory = new AnimalFactory();
            foodFactory = new FoodFactory();
            animals = new List<IAnimal>();
        }
        public IWriter Writer { get; private set; }

        public IReader Reader { get; private set; }

        public void Run()
        {
            string command = Reader.ReadLine();
            while(command != "End")
            {
                IAnimal newAnimal = animalFactory.CreateAnimal(command.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                string[] foodInfo = Reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IFood newFood = foodFactory.CreateFood(foodInfo[0], int.Parse(foodInfo[1]));
                Writer.WriteLine(newAnimal.Eat(newFood));
                animals.Add(newAnimal);
                command = Reader.ReadLine();
            }
            foreach(IAnimal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
