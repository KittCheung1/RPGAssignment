using RPGAssignment.Characters;

namespace RPGAssignment.Items
{
    class Weapon : Item
    {

        public int Damage { get; }
        public double AttackSpeed { get; }

        public Weapon(string name, int reqLevel, Slot slot, ClassType classType, int damage, double attackSpeed) : base(name, reqLevel, Slot.WEAPON, classType)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        //public string Axes { get; set; }
        //public string Bows { get; set; }
        //public string Daggers { get; set; }
        //public string Hammers { get; set; }
        //public string Staffs { get; set; }
        //public string Swords { get; set; }
        //public string Wands { get; set; }

    }
}
