namespace ClassTaskContinue
{
    internal partial class Program
    {
        class Inventory
        {
            //Task7
            public string _name;

        }
        class PotionOrWeapon : Inventory
        {
            public string AddInventoryPotionOrWeapon(string name)
            {
                _name= name;
                return _name;
            }
        }
    }
}
