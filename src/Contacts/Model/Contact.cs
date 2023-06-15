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
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Collections;

namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, INotifyDataErrorInfo
    {
        /// <summary>
        /// Словарь ошибок контакта.
        /// </summary>
        private readonly Dictionary<string, List<string>> _propertyErrors = 
            new Dictionary<string, List<string>>();

        /// <summary>
        /// Ограничение на максимальную длину.
        /// </summary>
        private readonly int _maxLength = 100;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Электронный адрес контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Хранит событие на изменение.
        /// Зажигается при изменении данных контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Хранит событие на ошибки валидации.
        /// Зажигается при возникновении ошибки валидации контакта.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

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
                    ClearError(nameof(Name));

                    if (_name.Length > _maxLength)
                    {
                        AddError(nameof(Name), $"{nameof(Name)} must be no" +
                            $" longer than 100 characters.");
                    }

                    OnPropertyChanged(nameof(HasErrors));
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
                    ClearError(nameof(PhoneNumber));

                    if (!Regex.IsMatch(_phoneNumber,
                        @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$") ||
                        _phoneNumber.Length > _maxLength)
                    {
                        AddError(nameof(PhoneNumber),
                            $"{nameof(PhoneNumber)} can contain only numbers" +
                            $" or the characters '+ - ( )'. Example:" +
                            $" +7 (999) 111-22-33.");
                    }

                    OnPropertyChanged(nameof(HasErrors));
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
                    ClearError(nameof(Email));

                    if (!Regex.IsMatch(_email,
                        @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$") ||
                            _email.Length > _maxLength)
                    {
                        AddError(nameof(Email), $"{nameof(Email)} must be no" +
                            $" longer than 100 characters," +
                            $" and must also contain '@' and '.'.");
                    }

                    OnPropertyChanged(nameof(HasErrors));
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <inheritdoc/>
        public bool HasErrors => _propertyErrors.Any();

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
        /// <param name="propertyName">Название свойства,
        /// для которого зажигается событие.</param>
        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propertyName));
        }

        /// <inheritdoc/>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyErrors.GetValueOrDefault(propertyName, null);
        }

        /// <summary>
        /// Добавляет ошибки в словарь.
        /// </summary>
        /// <param name="propertyName">Название свойства,
        /// где произошла ошибка.</param>
        /// <param name="errorMessage">Сообщение ошибки.</param>
        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<string>());
            }

            _propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        /// <summary>
        /// Удаляет ошибку из словаря.
        /// </summary>
        /// <param name="propertyName">Название свойства,
        /// ошибку которого нужно удалить.</param>
        public void ClearError(string propertyName)
        {
            if (_propertyErrors.Remove(propertyName))
            {
                OnPropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Зажигается при возникновении ошибки.
        /// </summary>
        /// <param name="propertyName">Название свойства,
        /// где произошла ошибка.</param>
        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }
    }
}