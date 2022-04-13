using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"The {propertyName} cannot be negative or equal to zero, " +
                    $"but was {value}");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"The {propertyName} cannot be negative or equal to zero, " +
                    $"but was {value}");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range from {min} to {max}, " +
                    $"but was {value}");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range from {min} to {max}, " +
                    $"but was {value}");
            }
        }

        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (var i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must contains letters only");
                }
            }
        }
    }
}
