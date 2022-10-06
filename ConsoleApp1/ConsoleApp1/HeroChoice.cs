using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HeroChoice
    {   

        public void AddHeroes(List<Hero> l)
        {
            Hero Knight = new Hero("Knight", 150, 25, 0);
            Hero Mage = new Hero("Mage", 80, 100, 0);
            Hero Archer = new Hero("Archer", 100, 35, 0);
            Hero Thief = new Hero("Thief", 90, 50, 30);

            l.Add(Knight);
            l.Add(Mage);
            l.Add(Archer);
            l.Add(Thief);
        }
        public void PrintHeroes(List<Hero> l)
        {
            int Check = 1;
            foreach (Hero hero in l)
            {
                Console.WriteLine("Class " + "(" + Check + ")");
                Check++;
                Console.WriteLine("Class: " + hero.Name);
                Console.WriteLine("HP: " + hero.HP);
                Console.WriteLine("Mana: " + hero.MP);
                Console.WriteLine("Starting XP: " + hero.XP);
            }

        }


   




    }
}
