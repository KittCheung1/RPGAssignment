using RPGAssignment.Characters;

namespace RPGAssignment.Items
{
    /// <summary>
    /// Item class.
    /// </summary>
    public abstract class Item
    {
        public string Name { get; }
        public int ReqLevel { get; }
        public Slot Slot { get; set; }

        public ClassType CharacterClassType { get; }

        protected Item(string name, int reqLevel, ClassType classType, Slot slot)
        {
            Name = name;
            ReqLevel = reqLevel;
            Slot = slot;
            CharacterClassType = classType;
        }
    }
}
