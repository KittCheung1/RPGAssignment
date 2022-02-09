using RPGAssignment.Characters;
using RPGAssignment.Items;
using System.Collections.Generic;

namespace RPGAssignment.Classes
{
    class Character
    {
        public string CharacterClass { get; set; }
        public int Level { get; set; }
        public Stats Stats { get; set; }
        private readonly Dictionary<Slot, Item> equpment;
    }


}

