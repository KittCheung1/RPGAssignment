using System;

namespace RPGAssignment.ExceptionHandling
{
    /// <summary>
    /// Class to handle Weapon Exceptions
    /// </summary>
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException()
        {
        }

        public InvalidWeaponException(string message) : base(message)
        {
        }

        public InvalidWeaponException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
