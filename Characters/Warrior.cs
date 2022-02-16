using RPGAssignment.Items;

namespace RPGAssignment.Characters
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name)
        {
            BaseStats = new Stats(5, 2, 1);
        }

        //public void PrintStats()
        //{
        //    Console.WriteLine($"{ BaseStats.Strength} { BaseStats.Dexterity} { BaseStats.Intelligence}");
        //}


        /// <summary>
        /// Overrides an abstract method to get the primary stat specifically for this class
        /// </summary>
        /// <param name="stats"> takes in the Stats class </param>
        /// <returns> returns this class's main/primary stat of the 3 available ones</returns>
        public override int GetPrimaryAttribute(Stats primaryAttribute)
        {
            return primaryAttribute.Strength;
        }

        /// <summary>
        /// Overrides the BaseStats /Attributes on levelup. Increase the stats for str, dex, int
        /// </summary>
        public override void OnLevelUp()
        {
            BaseStats += new Stats(3, 2, 1);
        }
        /// <summary>
        /// Overrides the CanEquipWeapon to check if weapon is suited for this classtype. in this case Warrior
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        public override bool CanEquipWeapon(Weapon weapon)
        {
            if (weapon.CharacterClassType == ClassType.WARRIOR)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Overrides the CanEquipArmor to check if armor is suited for this classtype. in this case Warrior
        /// </summary>
        /// <param name="armor"></param>
        /// <returns></returns>
        public override bool CanEquipArmor(Armor armor)
        {
            if (armor.CharacterClassType == ClassType.WARRIOR)
            {
                return true;
            }
            return false;
        }

    }
}
