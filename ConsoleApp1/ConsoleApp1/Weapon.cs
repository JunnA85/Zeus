using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapon
    {
        public string Name { get; set; }
        public int Dmg { get; set; }
        public int FromLvl { get; set; }
        public int PlusLvl {get; set;}
        public int SPConsuption { get; set; }
        public int MPConsuption { get; set; }

        public Weapon (string name, int dmg, int fromlvl, int pluslvl, int spconsuption, int mpconsuption)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.FromLvl = fromlvl;
            this.PlusLvl = pluslvl;
            this.SPConsuption = spconsuption;
            this.MPConsuption = mpconsuption;
        }
    }
}
