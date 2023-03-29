using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Vehicles.IO.Interfaces;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
       
        private IHeroFactory heroFactory;
        private List<IBaseHero> heroes;
        public Engine(IWriter writer, IReader reader)
        {
            Writer = writer;
            Reader = reader;
            heroFactory = new HeroFactory();
            heroes = new List<IBaseHero>();
        }

        public IWriter Writer { get; private set; }

        public IReader Reader {get; private set;}

        public void Run()
        {
            int numOfHeroes = int.Parse(Reader.ReadLine());
            while(numOfHeroes > 0)
            {
                IBaseHero hero = null;
                string name = Reader.ReadLine();
                string type = Reader.ReadLine();
                try
                {
                    hero = heroFactory.CreateHero(name, type);
                    numOfHeroes--;
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                if(hero != null)
                {
                    heroes.Add(hero);
                }
            }
            int powerOfBoss = int.Parse(Reader.ReadLine());
            foreach(IBaseHero hero in heroes)
            {
                Writer.WriteLine(hero.CastAbility());
                powerOfBoss -= hero.Power;
                
            }
            string message = powerOfBoss <= 0 ? "Victory!" : "Defeat...";
            Writer.WriteLine(message);
        }
    }
}
