using RPGAssignment.Characters;
using System;

namespace RPGAssignment.Items
{
    class Armor : Item
    {
        public Stats Stats { get; set; }

        //public string Cloth { get; set; }
        //public string Leather { get; set; }
        //public string Mail { get; set; }
        //public string Plate { get; set; }
        public Armor(string name, int reqLevel, Slot slot, ClassType classType, Stats stats) : base(name, reqLevel, slot, classType)
        {
            Stats = stats;
            if (Slot == Slot.WEAPON)
            {
                throw new ArgumentException("Armor can not be used in a Weapon slot.", nameof(slot));
            }
        }
    }
}
