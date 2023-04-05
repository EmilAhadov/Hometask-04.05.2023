using static System.Net.Mime.MediaTypeNames;

namespace ClassTaskContinue
{
    internal partial class Program
    {
        class Weapon
        {
            //Task8
            private int _durability;
            private int _damage;

            public Weapon(int durability, int damage)
            {
                _durability= durability;
                _damage = damage;
            }
        }
    }
}
