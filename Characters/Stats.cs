
namespace RPGAssignment.Characters
{
    /// <summary>
    /// Stats class with properties of the 3 main stats. A stats operator to count new stats on level up
    /// </summary>
    public class Stats
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

        public static Stats operator +(Stats lhs, Stats rhs)
        {
            return new Stats(lhs.Strength + rhs.Strength, lhs.Dexterity + rhs.Dexterity, lhs.Intelligence + rhs.Intelligence);
        }


    }

}

