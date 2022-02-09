using RPGAssignment.Characters;
using RPGAssignment.Items;
using System.Collections.Generic;

namespace RPGAssignment.Classes
{   // Base class to create the other subclasses like Mage, Rouge ect
    abstract class Character
    {
        public int Level { get; set; }
        public Stats BaseStats { get; set; }
        private readonly Dictionary<Slot, Item> equpment;

        // Protected Constructor because Character class is abstract
        protected Character()
        {
            BaseStats = default;
            Level = 1;
            equpment = new Dictionary<Slot, Item>();
        }
    }


}

