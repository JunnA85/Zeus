using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Monster
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int PhysDmg { get; set; }
        public int MagicDmg { get; set; }
        public int FireDmg { get; set; }
        public int FrostDmg { get; set; }
        public int PoisonDmg { get; set; }
        public int DarkDmg { get; set; }
        public int SpiritDmg { get; set; }

        public Monster(string name, int hp, int physdmg, int magicdmg, int firedmg, int frostdmg, int poisondmg, int darkdmg, int spiritdmg)
        {
            this.Name = name;
            this.HP = hp;
            this.PhysDmg = physdmg;
            this.MagicDmg = magicdmg;
            this.FireDmg = firedmg;
            this.FrostDmg = frostdmg;
            this.PoisonDmg = poisondmg;
            this.DarkDmg = darkdmg;
            this.SpiritDmg = spiritdmg;
        }
    }
}
