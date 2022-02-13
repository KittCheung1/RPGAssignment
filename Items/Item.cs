using RPGAssignment.Characters;

namespace RPGAssignment.Items
{
    abstract class Item
    {
        public string Name { get; }
        public int ReqLevel { get; }
        public Slot Slot { get; }

        public ClassType CharacterClassType { get; }

        protected Item(string name, int reqLevel, Slot slot, ClassType classType)
        {
            Name = name;
            ReqLevel = reqLevel;
            Slot = slot;
            CharacterClassType = classType;
        }
    }
}
