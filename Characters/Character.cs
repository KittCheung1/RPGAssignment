using RPGAssignment.ExceptionHandling;
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
        //properties
        public string Name { get; set; }
        public int Level { get; set; }
        public Stats BaseStats { get; set; }
        private readonly Dictionary<Slot, Item> equpment;

        /// <summary>
        /// Protected Constructor because Character class is abstract and only for inheritance
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
            OnLevelUp();
        }

        /// <summary>
        /// Check what type of item that is going to be equiped
        /// </summary>
        /// <param name="item"></param>
        public void EquipItem(Item item)
        {
            if (item is Weapon weapon)
            {
                CheckEquipWeapon(weapon);
            }
            if (item is Armor armor)
            {
                Console.WriteLine("you can/ cant equip this armor");
            }
        }
        /// <summary>
        /// Check Requirement to use this weapon. Level and classtype
        /// </summary>
        /// <param name="weapon"></param>
        /// <exception cref="Exception"></exception>
        public void CheckEquipWeapon(Weapon weapon)
        {
            if (weapon.ReqLevel > Level)
            {
                throw new InvalidWeaponException($"Your level is too low to equip this weapon. Required level = {weapon.ReqLevel}. Current level = {Level}");
            }
            if (!CanEquipWeapon(weapon))
            {
                throw new InvalidWeaponException($"You are the wrong class to equip this weapon");
            }
        }

        /// <summary>
        /// Check Requirement to use this armor. Level and classtype
        /// </summary>
        /// <param name="armor"></param>
        /// <exception cref="Exception"></exception>
        public void CheckEquipArmor(Armor armor)
        {
            if (armor.ReqLevel > Level)
            {
                throw new InvalidArmorException($"Your level is too low to equip this armor. Required level = {armor.ReqLevel}. Current level = {Level}");
            }
            if (!CanEquipArmor(armor))
            {
                throw new InvalidArmorException($"You are the wrong class to equip this armor");
            }
        }
        public float GetDamage() { return 0; }
        public Stats GetTotalStats() { return null; }
        public void DisplayStats()
        {

            // StringBuilder of all the character information
            // "stringbuilder of Character to Display";
            string name = Name;
            var totalStats = GetTotalStats();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Strength: {totalStats.Strength}");
            Console.WriteLine($"Dexterity: {totalStats.Dexterity}");
            Console.WriteLine($"Intelligence: {totalStats.Intelligence}");
            //Console.WriteLine($"Damage: {GetDamage()}");
        }
        /// <summary>
        /// Get primary attribute for the classtype
        /// </summary>
        /// <param name="primaryAttribute"></param>
        /// <returns></returns>
        public abstract int GetPrimaryAttribute(Stats primaryAttribute);
        /// <summary>
        /// Check if  a certain character classtype can Equip a certain weapon
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        public abstract bool CanEquipWeapon(Weapon weapon);

        /// <summary>
        /// Check if Character can Equip a certain armor
        /// </summary>
        /// <param name="armor"></param>
        /// <returns></returns>
        public abstract bool CanEquipArmor(Armor armor);

        /// <summary>
        /// Abstract Method is called when Character levels up. Change Stats unique for each character
        /// </summary>
        public abstract void OnLevelUp();
    }
}

