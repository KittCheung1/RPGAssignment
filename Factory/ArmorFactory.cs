using RPGAssignment.Characters;
using RPGAssignment.Items;

namespace RPGAssignment.Factory
{
    /// <summary>
    /// Factory of Creating armor setting requirement for each armor to each Classtype and Slot
    /// </summary>
    public abstract class ArmorFactory
    {
        public static Armor CreateClothHead()
        {
            var stats = new Stats(0, 0, 5);
            return new Armor("Common cloth head armor", 1, ClassType.MAGE, Slot.HEAD, stats);
        }

        public static Armor CreateLeatherLegs()
        {
            var stats = new Stats(0, 3, 0);
            return new Armor("Common leather legs armor", 1, ClassType.RANGER | ClassType.ROUGE, Slot.LEGS, stats);
        }

        public static Armor CreateMailBody()
        {
            var stats = new Stats(2, 2, 0);
            return new Armor("Common mail body armor", 1, ClassType.RANGER | ClassType.ROUGE | ClassType.WARRIOR, Slot.BODY, stats);
        }

        public static Armor CreatePlateBody()
        {
            var stats = new Stats(1, 0, 0);
            return new Armor("Common plate body armor", 1, ClassType.WARRIOR, Slot.BODY, stats);
        }

        public static Armor CreatePlateBodyLvl2()
        {
            var stats = new Stats(1, 0, 0);
            return new Armor("Common plate body armor", 2, ClassType.WARRIOR, Slot.BODY, stats);
        }
    }
}
