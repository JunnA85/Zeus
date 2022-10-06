using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int XP { get; set; }

        public Hero(string name, int hp, int mp, int xp)
        {
            this.Name = name;
            this.HP = hp;
            this.MP = mp;
            this.XP = xp;

        }
    }
}
