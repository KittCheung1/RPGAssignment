using RPGAssignment.Characters;
using System;

namespace RPGAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var warrior = new Warrior("Sven");
            warrior.levelUp();
        }

    }
}
