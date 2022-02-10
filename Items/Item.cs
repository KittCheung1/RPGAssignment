namespace RPGAssignment.Items
{
    abstract class Item
    {
        public string Name { get; }
        public int ReqLevel { get; }
        public Slot Slot { get; }

        protected Item(string name, int reqLevel, Slot slot)
        {
            Name = name;
            ReqLevel = reqLevel;
            Slot = slot;
        }
    }
}
