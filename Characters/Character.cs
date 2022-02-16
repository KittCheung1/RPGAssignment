using RPGAssignment.ExceptionHandling;
using RPGAssignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGAssignment.Characters
{

    /// <summary>
    /// Base class to create the other subclasses like Mage, Rouge ect
    /// Abstract because base class is not supposed to be instantiated
    /// </summary>
    public abstract class Character
    {
        //properties
        public string Name { get; set; }
        public int Level { get; set; }
        public Stats BaseStats { get; set; }
        private readonly Dictionary<Slot, Item> equipment;

        /// <summary>
        /// Protected Constructor because Character class is abstract and only for inheritance
        /// Default properties for each subclass
        /// </summary>
        protected Character(string name)
        {
            Name = name;
            Level = 1;
            equipment = new Dictionary<Slot, Item>();
        }
        /// <summary>
        /// LevelUp increases level with 1, calls a method OnLevelUp()
        /// </summary>
        public void LevelUp()
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
            if (item is Weapon)
            {
                CheckEquipWeapon(item as Weapon);
            }
            else if (item is Armor)
            {
                CheckEquipArmor((item as Armor));
            }
            else
            {
                throw new InvalidOperationException("Its not a weapon nor an armor");
            }

            equipment[item.Slot] = item;
        }
        /// <summary>
        /// Check Requirement to use this weapon. Level and classtype
        /// </summary>
        /// <param name="weapon"></param>
        /// <exception cref="Exception"></exception>
        public string CheckEquipWeapon(Weapon weapon)
        {
            try
            {
                if (weapon.ReqLevel > Level)
                {
                    throw new InvalidWeaponException($"Your level is too low to equip this weapon. Required level = {weapon.ReqLevel}. Current level = {Level}");
                }
                else if (!CanEquipWeapon(weapon))
                {
                    throw new InvalidWeaponException($"You are the wrong class to equip this weapon");
                }
                else if (weapon.ReqLevel == Level)
                {
                    return "New weapon equipped!";
                }
                return "false";
            }

            catch (InvalidWeaponException ex)
            {
                return ex.Message;
            }


        }

        /// <summary>
        /// Check Requirement to use this armor. Level and classtype
        /// </summary>
        /// <param name="armor"></param>
        /// <exception cref="Exception"></exception>
        public string CheckEquipArmor(Armor armor)
        {
            try
            {
                if (armor.ReqLevel > Level)
                {
                    throw new InvalidArmorException($"Your level is too low to equip this armor. Required level = {armor.ReqLevel}. Current level = {Level}");
                }
                else if (!CanEquipArmor(armor))
                {
                    throw new InvalidArmorException($"You are the wrong class to equip this armor");
                }
                else if (Level >= armor.ReqLevel)
                {
                    return "New armor equipped!";
                }
                return "false";
            }
            catch (InvalidArmorException ex)
            {

                return ex.Message;
            }
        }
        /// <summary>
        /// Calcultate dps based on Attribute and equipped Weapon, if any.
        /// </summary>
        /// <returns></returns>
        public double GetDamage()
        {
            var equippedWeapon = GetEquippedWeapon();
            if (equippedWeapon is null)
                return 1;

            double dps = equippedWeapon.Damage * equippedWeapon.AttackSpeed;

            return dps * (1 + GetPrimaryAttribute(GetTotalStats()) / 100);
        }
        /// <summary>
        /// Set equip item to Weapon-slot if Item is weapon
        /// </summary>
        /// <returns></returns>
        public Weapon GetEquippedWeapon()
        {
            if (equipment.ContainsKey(Slot.WEAPON))
            {
                return equipment[Slot.WEAPON] as Weapon;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Set equip item to Armor-slot if Item is armor
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Armor> GetEquippedArmor()
        {
            var equippedArmor = new List<Armor>();

            foreach (var itemSlot in equipment)
            {
                if (itemSlot.Value is Armor armor)
                    equippedArmor.Add(armor);
            }

            return equippedArmor;
        }
        /// <summary>
        /// Get new totalstats when armor is equipped
        /// </summary>
        /// <returns></returns>
        public Stats GetTotalStats()
        {
            var equippedArmor = GetEquippedArmor();
            return new Stats(
                BaseStats.Strength + equippedArmor.Sum(x => x.Stats.Strength),
                BaseStats.Dexterity + equippedArmor.Sum(x => x.Stats.Dexterity),
                BaseStats.Intelligence + equippedArmor.Sum(x => x.Stats.Intelligence));
        }

        /// <summary>
        /// Display Characters name and current Full Stats 
        /// </summary>
        public void DisplayCharacterStats()
        {
            string name = Name;
            var totalStats = GetTotalStats();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Strength: {totalStats.Strength}");
            Console.WriteLine($"Dexterity: {totalStats.Dexterity}");
            Console.WriteLine($"Intelligence: {totalStats.Intelligence}");
            Console.WriteLine($"Damage: {GetDamage()}");
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

