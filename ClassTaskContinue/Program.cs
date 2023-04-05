using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassTaskContinue
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region Task4
            //PlayerTask4 player = new PlayerTask4(int.Parse(Console.ReadLine()));
            //if (player._health >= 60 ) 
            //{
            //    TreasureChest bonusDamage = new TreasureChest();
            //    TreasureChest printer = new TreasureChest();
            //    printer.ShowDamage();
            //}

            #endregion

            #region Task7
            Inventory[] inventories = new Inventory[100];
            int i = 0;
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Please add weapon or potion: ");
                PotionOrWeapon potion= new PotionOrWeapon();
                inventories[i]._name = Console.ReadLine();
                i++;
                Console.WriteLine("Do you want to exit: ");
                exit = bool.Parse(Console.ReadLine());  
            }

            #endregion
        }
    }
}
