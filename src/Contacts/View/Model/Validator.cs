using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace View.Model
{
    /// <summary>
    /// Предоставляет методы для валидации.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда строка строка состоит не только из букв.</exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (var i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]) && !char.IsWhiteSpace(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must contains letters only.");
                }
            }
        }

        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение не входит в заданный диапазон.</exception>
        public static void AssertValueInRange(int value, int max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range up to {max}, " +
                    $"but was {value}.");
            }
        }

        /// <summary>
        /// Проверяет, что строка является номером телефона.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда строка не начинается с "+" или не содержит 11 цифр.</exception>
        public static void IsPhoneValid(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^(\+)[\d]{11}$"))
            {
                throw new ArgumentException(
                    $"The {propertyName} must start with '+' and contain 11 digits.");
            }
        }

        /// <summary>
        /// Проверяет, что строка является почтой.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает,
        /// когда строка не явлется почтой.</exception>
        public static void IsEmailValid(string value, string propertyName)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(value);
            }
            catch
            {
                throw new ArgumentException($"The {propertyName} is incorrect.");
            }
        }
    }
}
