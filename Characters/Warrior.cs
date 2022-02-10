using RPGAssignment.Items;
using System;

namespace RPGAssignment.Characters
{
    class Warrior : Character
    {
        public Warrior(string name) : base(name)
        {
            BaseStats = new Stats(5, 2, 1);
        }

        public void PrintStats()
        {
            Console.WriteLine($"{ BaseStats.Strength} { BaseStats.Dexterity} { BaseStats.Intelligence}");
        }


        /// <summary>
        /// Overrides an abstract method to get the primary stat of this class
        /// </summary>
        /// <param name="stats"> takes in the Stats class </param>
        /// <returns> returns this class's main stats of the 3 available ones</returns>
        public override int GetPrimaryAttribute(Stats primaryAttribute)
        {
            return primaryAttribute.Strength;
        }
        public void OnLevelUp()
        {
            BaseStats += new Stats(3, 2, 1);
        }
        public override bool CanEquipWeapon(Weapon weapon)
        {
            //if (weapon is suited for warrior)
            //{
            //  return true
            //}
            throw new System.NotImplementedException();
        }
        public override bool CanEquipArmor(Armor armor)
        {
            //if (armor is suited for warrior)
            //{
            //  return true
            //}
            throw new System.NotImplementedException();
        }
    }
}
