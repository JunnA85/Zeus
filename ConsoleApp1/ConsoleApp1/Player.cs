using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public string Name { get; set; }
        public Hero třída { get; set; }
        public Weapon weapon { get; set; }
        public List<Inventory> inv { get; set; }
    }
}
