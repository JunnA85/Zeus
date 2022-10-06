using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------------------
            //-----------Creating instances of functions----------------------------------------------------------

            Player p = new Player();
            Weapons W = new Weapons();
            Random rnd = new Random();
            Monsters M = new Monsters();
            Functions F = new Functions();
            HeroChoice HC = new HeroChoice();
            //--- --- ---
            // HERE I WOULD MAKE A CHOICE IF THEY WANT TO PLAY ARENA OR STORY MODE, THERES ONLY BEGGING FOR THE STORY MODE
            
            //--- --- ---
        //-----------Creating Lists for Inventory-------------------------------------------------------------
            List<Weapon> WeaponsInv = new List<Weapon>();
            List<Item> ItemsInv = new List<Item>();
        //-----------Name and Class Choosing Menu-------------------------------------------------------------
            List<Hero> MainHeroes = new List<Hero>();
            HC.AddHeroes(MainHeroes);
            List<Monster> monsters = new List<Monster>();
            //M.AddMonster(monsters);
            Console.WriteLine("Choose your name");
            p.Name = Console.ReadLine();
            Console.WriteLine("Choose your class");      
            HC.PrintHeroes(MainHeroes);
            int ClassDecision = Convert.ToInt32(Console.ReadLine());
            while(ClassDecision > MainHeroes.Count)
             {
                Console.WriteLine("You can choose only between 1 - " + MainHeroes.Count);
                ClassDecision = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(ClassDecision);
            if (ClassDecision == 1)
                p.třída = MainHeroes[ClassDecision - 1];
            if (ClassDecision == 2)
                p.třída = MainHeroes[ClassDecision - 1];
            if (ClassDecision == 3)
                p.třída = MainHeroes[ClassDecision - 1];
            if (ClassDecision == 4)
                p.třída = MainHeroes[ClassDecision - 1];
        //---------------Giving Weapon for correct class------------------------------------------------------
            Console.Clear();
            Console.WriteLine(p.Name + " " + p.třída.Name);
            if (p.třída.Name == "Knight")
                WeaponsInv.Add(W.Broadsword);
            if (p.třída.Name == "Mage")
                WeaponsInv.Add(W.SorcererStaff);
            if (p.třída.Name == "Archer")
                WeaponsInv.Add(W.WoodenBow);
            if (p.třída.Name == "Thief")
                WeaponsInv.Add(W.Dagger);
            //---------------Giving Basic Item--------------------------------------------------------------------
            F.AddBasicItems(ItemsInv);
            //---------------Welcoming to the Game----------------------------------------------------------------
            Console.WriteLine("Welcome to the Zeus - The Begging, our new");
            Console.WriteLine("AAA RPG inspired by one and only Skyrim");
            
            Console.ReadLine();
            F.AddBasicItems(ItemsInv);
            Console.WriteLine("Your Inventory");
            F.ShowInventory(WeaponsInv, ItemsInv);

            Console.ReadLine();
        }
    }
}
