using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Model;
using System.Collections;

namespace ViewModel
{
    public partial class ContactVM : ObservableObject, ICloneable, IDataErrorInfo
    {
        /// <summary>
        /// Контакт.
        /// </summary>
        [ObservableProperty]
        private Contact _contact;

        /// <summary>
        /// Хранит событие на изменение.
        /// Зажигается при изменении данных контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        [StringLength(100, ErrorMessage =
            $"{nameof(Name)} must be no longer than 100 characters.")]
        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                if (value != Contact.Name)
                {
                    Contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        [StringLength(100, ErrorMessage =
            $"{nameof(PhoneNumber)} must be no longer than 100 characters.")]
        [Phone(ErrorMessage =
            $"{nameof(PhoneNumber)} can only contain numbers or the" +
            $" characters '+ - ( )'. Example: +7 (999) 111-22-33.")]
        public string PhoneNumber
        {
            get
            {
                return Contact.PhoneNumber;
            }
            set
            {
                if (value != Contact.PhoneNumber)
                {
                    Contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        [StringLength(100, ErrorMessage =
            $"{nameof(Email)} must be no longer than 100 characters.")]
        [EmailAddress(ErrorMessage =
            $"{nameof(Email)} must contain the character @.")]
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                if (value != Contact.Email)
                {
                    Contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает контакт.
        /// </summary>

        /// <inheritdoc/>
        string IDataErrorInfo.this[string propertyName]
        {
            get
            {
                return Validate(propertyName);
            }
        }

        /// <inheritdoc/>
        public string Error
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _hasError = false;

        /// <summary>
        /// 
        /// </summary>
        public bool HasError
        {
            get
            {
                return _hasError;
            }

            set
            {
                _hasError = value;
                OnPropertyChanged(nameof(HasError));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Создает клон экземпляра класса <see cref="ContactVM"/>.
        /// </summary>
        /// <returns>Возвращает клон экземпляра.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }

        /// <summary>
        /// Проверяет полученные данные.
        /// </summary>
        /// <param name="propertyName">Данные,
        /// которые нужно проверить.</param>
        /// <returns></returns>
        private string Validate(string propertyName)
        {
            var value = GetType().GetProperty(propertyName).GetValue(
                this, null);
            var results = new List<ValidationResult>();

            var context = new ValidationContext(this, null, null)
            {
                MemberName = propertyName
            };

            if (!Validator.TryValidateProperty(value, context, results))
            {
                HasError = true;
                return results.First().ErrorMessage;
            }

            HasError = false;
            return string.Empty;
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
