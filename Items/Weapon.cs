using RPGAssignment.Characters;

namespace RPGAssignment.Items
{
    /// <summary>
    /// Weapon class inherit from Item class. Property of Stats for weapon. Constructor checking Slot 
    /// </summary>
    public class Weapon : Item
    {

        public int Damage { get; }
        public double AttackSpeed { get; }

        public Weapon(string name, int reqLevel, ClassType classType, int damage, double attackSpeed) : base(name, reqLevel, classType, Slot.WEAPON)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
            Slot = Slot.WEAPON;
        }

    }
}
