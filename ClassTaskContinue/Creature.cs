namespace ClassTaskContinue
{
    internal partial class Program
    {
        class Creature
        {
            //Task2
            public int health { get; set; }
            public int mana { get; set; }
            public int inventory { get; set; }
            void Attack() { }
            void UseItem() { }

            class Player : Creature { }
            class Enemy : Creature { }



        }



    }
}
