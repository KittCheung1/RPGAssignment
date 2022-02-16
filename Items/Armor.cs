using RPGAssignment.Characters;
using System;

namespace RPGAssignment.Items
{
    /// <summary>
    /// Armor class inherit from Item class. Property of Stats for armors. Constructor checking Slot 
    /// that only armor-type of items can be stored in the slot and not weapon-type items.
    /// </summary>
    public class Armor : Item
    {
        public Stats Stats { get; set; }

        public Armor(string name, int reqLevel, ClassType classType, Slot slot, Stats stats) : base(name, reqLevel, classType, slot)
        {
            Stats = stats;
            if (Slot == Slot.WEAPON)
            {
                throw new ArgumentException("Armor can not be used in a Weapon slot.", nameof(slot));
            }
        }
    }
}
