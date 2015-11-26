namespace _02.BankOfKurtovoKonare.Utils
{
    using System;

    /// <summary>
    /// Static class with simple validators
    /// <para>By VDonchev</para>
    /// </summary>
    public static class Validator
    {
        public static void IsNull<T>(T item, string type)
        {
            if (item == null)
            {
                throw new ArgumentNullException(type, string.Format(MessageTeplates.CantBeNull, type));
            }
        }

        public static void IsNullOrEmpty(string item, string type)
        {
            if (string.IsNullOrEmpty(item.Trim()))
            {
                throw new ArgumentException(string.Format(MessageTeplates.CantBeNullOrEmpty, type));
            }
        }

        public static void StrLenIsInRange(string str, int min, int max, string type)
        {
            if (str.Length < min || str.Length > max)
            {
                throw new ArgumentException(string.Format(MessageTeplates.StrLenIsNotInRange, type, min, max));
            }
        }

        public static void IsNegative(dynamic num, string type)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(type, string.Format(MessageTeplates.CantBeNegative, type));
            }
        }

        public static void IsNegativeOrZero(dynamic num, string type)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException(type, string.Format(MessageTeplates.CantBeNegativeOrZero, type));
            }
        }

        public static void IsInRange(dynamic num, dynamic min, dynamic max, string type)
        {
            if (num < min || num > max)
            {
                throw new ArgumentOutOfRangeException(type, string.Format(MessageTeplates.IsNotInRange, type, min, max));
            }
        }
    }
}