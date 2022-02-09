namespace RPGAssignment.Items
{
    abstract class Item
    {
        public string Name { get; set; }
        public int ReqLevel { get; set; }
        public string Slot { get; set; }
    }
}
