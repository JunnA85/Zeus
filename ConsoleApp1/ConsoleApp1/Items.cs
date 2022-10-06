using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Items
    {
    //---------------Basic Items----------------------------------------------------------------
        public Item BasicSmallHPPotion = new Item("Small Healing Potion", 5, 1, 25, 0);
        public Item BasicSmallMPPotion = new Item("Small Mana Potion", 5, 1, 0, 25);
        public Item BasicCoins = new Item("Gold Coin", 1, 15);

    //---------------All Other Items------------------------------------------------------------
       public Item SmallHPPotion = new Item("Small Healing Potion", 5, 1, 25, 0);
       public Item SmallMPPotion = new Item("Small Mana Potion", 5, 1, 0, 25);
    }
}
