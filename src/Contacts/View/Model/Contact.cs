using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Электронный адрес контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит событие на изменение.
        /// Зажигается при изменении данных контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value != _phoneNumber)
                {
                    _phoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
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
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Почта.</param>
        [JsonConstructor]
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Создает клон экземпляра класса <see cref="Contact"/>.
        /// </summary>
        /// <returns>Возвращает клон экземпляра.</returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }

        /// <summary>
        /// Зажигает событие.
        /// </summary>
        /// <param name="prop">Название свойства,
        /// для которого зажигается событие.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
