using RPGAssignment.Items;
using System;
using System.Collections.Generic;

namespace RPGAssignment.Characters
{

    /// <summary>
    /// Base class to create the other subclasses like Mage, Rouge ect
    /// Abstract because base class is not supposed to be instantiated
    /// </summary>
    abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Stats BaseStats { get; set; }
        private readonly Dictionary<Slot, Item> equpment;

        /// <summary>
        /// Protected Constructor because Character class is abstract
        /// Default properties for each subclass
        /// </summary>
        protected Character(string name)
        {
            Name = name;
            Level = 1;
            equpment = new Dictionary<Slot, Item>();
        }
        /// <summary>
        /// LevelUp increases level with 1, calls a method onLevelUp()
        /// </summary>
        public void levelUp()
        {
            Level++;
            onLevelUp();
        }
        public float GetDamage() { return 0; }
        public Stats GetTotalStats() { return null; }
        public void DisplayStats()
        {

            // StringBuilder of all the character information
            // "stringbuilder of Character to Display";
            string name = "sheesh";
            var totalStats = GetTotalStats();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Strength: {totalStats.Strength}");
            Console.WriteLine($"Dexterity: {totalStats.Dexterity}");
            Console.WriteLine($"Intelligence: {totalStats.Intelligence}");
            //Console.WriteLine($"Damage: {GetDamage()}");
        }
        public abstract int GetPrimaryAttribute(Stats stats);

        public abstract bool CanEquipWeapon(Weapon weapon);

        public abstract bool CanEquipArmor(Armor armor);

        public void onLevelUp() { }
    }
}

