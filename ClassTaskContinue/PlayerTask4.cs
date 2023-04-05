using System;
using static System.Net.Mime.MediaTypeNames;

namespace ClassTaskContinue
{
    internal partial class Program
    {
        public class PlayerTask4
        {
            //Task4

            public int _health;

            public PlayerTask4(int health)
            {
                _health= health;
            }


        }
        public class TreasureChest
        {
            public int _damage;
            public TreasureChest()
            {
                _damage += 10;
            }
            
            public void ShowDamage()
            {
                Console.WriteLine(_damage);
            }

        }

    }
}
