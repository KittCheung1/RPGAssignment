using System.Collections.Generic;

namespace RPGAssignment.Classes
{
    class Player
    {
        public string CharacterClass { get; set; }
        public int Level { get; set; }
        public Stats Stats { get; set; }
        private readonly Dictionary<Slot, Item> equpment;
    }
    class Mage : Player
    {
        public Mage()
        {
            Stats = new Stats(1, 1, 8);
        }
    }
    class Rouge : Player
    {
        public Rouge()
        {
            Stats = new Stats(2, 6, 1);
        }
    }
    class Warrior : Player
    {
        public Warrior()
        {

            Stats = new Stats(5, 2, 1);
        }
    }
    class Ranger : Player
    {
        public Ranger()
        {
            Stats = new Stats(1, 7, 1);

        }
    }
    class Stats
    {
        public Stats(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
    }
    abstract class Item
    {
        public string Name { get; set; }
        public int ReqLevel { get; set; }
        public string Slot { get; set; }
    }
    class WeaponFactory
    {

    }
    class ArmorFactory
    {

    }
    class Weapons : Item
    {
        public string Axes { get; set; }
        public string Bows { get; set; }
        public string Daggers { get; set; }
        public string Hammers { get; set; }
        public string Staffs { get; set; }
        public string Swords { get; set; }
        public string Wands { get; set; }

    }
    class Armors : Item
    {
        public string Cloth { get; set; }
        public string Leather { get; set; }
        public string Mail { get; set; }
        public string Plate { get; set; }

    }
    enum Slot
    {
        Head,
        Body,
        Legs,
        Weapon
    }
}

