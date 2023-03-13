using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Ограничение на количество символов в имяни контакта.
        /// </summary>
        private readonly int _characterLimit = 150;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// Должно состоять только из букв. Длина не более 150 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                Validator.AssertValueInRange(value.Length, _characterLimit, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// Должен начинаться с "+" и содержать 11 цифр.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                Validator.IsPhoneValid(value, nameof(Phone));
                _phone = value;
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// Должен быть корректным.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Validator.IsEmailValid(value, nameof(Email));                
                _email = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="email">Почта.</param>
        [JsonConstructor]
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
