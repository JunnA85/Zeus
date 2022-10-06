using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Ammount { get; set; }
        public int HPAddition { get; set; }
        public int MPAddition { get; set; }

        public Item(string name, int value, int ammount) //Normal items
        {
            this.Name = name;
            this.Value = value;
            this.Ammount = ammount;

        }
        public Item(string name, int value, int ammount, int hpaddtion, int mpaddition) //Potions
        {
            this.Name = name;
            this.Value = value;
            this.Ammount = ammount;
            this.HPAddition = hpaddtion;
            this.MPAddition = mpaddition;

        }



    }
}
