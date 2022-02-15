using System;

namespace RPGAssignment.ExceptionHandling
{
    /// <summary>
    /// Class to handle Armor Exceptions
    /// </summary>
    internal class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }
        public InvalidArmorException(string message) : base(message)
        {
        }

        public InvalidArmorException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
