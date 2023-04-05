namespace ClassTaskContinue
{
    internal partial class Program
    {
        public abstract class CreatureTask5AndTask6
        {
            //Task5
            public int health { get; set; }
            public int mana { get; set; }
            public int inventory { get; set; }
            public abstract void Attack();
            public abstract void UseItem();


        }
        public class Orc : CreatureTask5AndTask6
        {
            public override void Attack()
            {
                throw new System.NotImplementedException();
            }

            public override void UseItem()
            {
                throw new System.NotImplementedException();
            }
        }
        public class Goblin : CreatureTask5AndTask6
        {
            public override void Attack()
            {
                throw new System.NotImplementedException();
            }

            public override void UseItem()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
