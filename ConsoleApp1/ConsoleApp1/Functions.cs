using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Functions
    {
        Random rnd = new Random();
        public void WhatMonster(List<Monster> m, int decision)
        {
            int RndIndex = rnd.Next(0, m.Count);
            


        }
        public int Attack(Hero h, Monster m, Weapon w)
        {
            Console.WriteLine("Životy: " + m.HP);
            m.HP -= w.Dmg;
            Console.WriteLine("Udělen dmg: " + w.Dmg);
            Console.WriteLine("Životy: " + m.HP);
            return m.HP;

        }
        public void ShowInventory(List<Weapon> w, List<Item> i)
        {
            Console.WriteLine("--- --- --- ---");
            Console.WriteLine("Weapons ");
            foreach (Weapon weapon in w)
            {
                Console.WriteLine("Name: " + weapon.Name + " Damage: " + weapon.Dmg);
            }          
            Console.WriteLine("--- --- --- ---");
            Console.WriteLine("Items ");
            foreach (Item item in i)
            {
                Console.WriteLine("Name: " + item.Name + " Value: " + item.Value + " Have: " + item.Value + "x");
            }
        }
        public void AddBasicItems(List<Item> l)
        {
            Items I = new Items();
            l.Add(I.BasicSmallHPPotion);
            l.Add(I.BasicSmallMPPotion);
            l.Add(I.BasicCoins);
        }
        //------------Physical Resistances Calculators-------------------------------------------------------
        public double PhysResCalc(Armor a, Monster m)
        {
            double EndPhysDmg = (1 - a.PhysicalDamageRes) * m.PhysDmg; 
            return EndPhysDmg;
        }
        public double MagicResCalc(Armor a, Monster m)
        {
            double EndMagicDmg = (1 - a.MagicalDamageRes) * m.MagicDmg;
            return EndMagicDmg;
        }
        public double FireResCalc(Armor a, Monster m)
        {
            double EndFireDmg = (1 - a.FireResistance) * m.FireDmg;
            return EndFireDmg;
        }
        public double FrostResCalc(Armor a, Monster m)
        {
            double EndFrostDmg = (1 - a.FrostResistance) * m.FrostDmg;
            return EndFrostDmg;
        }
        public double PoisonResCalc(Armor a, Monster m)
        {
            double EndPoisonDmg = (1 - a.PoisonResistance) * m.PoisonDmg;
            return EndPoisonDmg;
        }
        public double DarkResCalc(Armor a, Monster m)
        {
            double EndDarkDmg = (1 - a.DarknessResistance) * m.DarkDmg;
            return EndDarkDmg;
        }
        public double SpiritResCalc(Armor a, Monster m)
        {
            double EndSpiritDmg = (1 - a.SpiritResistance) * m.SpiritDmg;
            return EndSpiritDmg;
        }
        //----------------------------------------------------------------------------------------------------






    }
}
