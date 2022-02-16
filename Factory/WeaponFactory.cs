using RPGAssignment.Characters;
using RPGAssignment.Items;

namespace RPGAssignment.Factory
{
    /// <summary>
    /// Factory of Creating weapon setting requirement for each weapon to each Classtype
    /// </summary>
    public abstract class WeaponFactory
    {
        public static Weapon CreateStaff()
        {
            return new Weapon("Staff for the wice", 3, ClassType.MAGE, 20, 0.7);
        }

        public static Weapon CreateWand()
        {
            return new Weapon("Common Wand", 1, ClassType.MAGE, 10, 1.0);
        }

        public static Weapon CreateBow()
        {
            return new Weapon("Common Bow", 1, ClassType.RANGER, 12, 0.8);
        }

        public static Weapon CreateDagger()
        {
            return new Weapon("Common Dagger", 1, ClassType.ROUGE, 5, 2.0);
        }

        public static Weapon CreateSword()
        {
            return new Weapon("Common Sword", 1, ClassType.ROUGE | ClassType.WARRIOR, 7, 1.1);
        }

        public static Weapon CreateAxe()
        {
            return new Weapon("Common Axe", 1, ClassType.WARRIOR, 7, 1.1);
        }

        public static Weapon CreateAxeLvl2()
        {
            return new Weapon("Common Axe", 2, ClassType.WARRIOR, 7, 1.1);
        }

        public static Weapon CreateHammer()
        {
            return new Weapon("Hammer time", 3, ClassType.WARRIOR, 23, 0.6);
        }
    }
}
