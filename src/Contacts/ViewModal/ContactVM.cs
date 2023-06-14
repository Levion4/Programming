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
using System.Text.RegularExpressions;

namespace ViewModel
{
    /// <summary>
    /// ViewModel контакта.
    /// </summary>
    public partial class ContactVM : ObservableObject, ICloneable, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _propertyErrors = 
            new Dictionary<string, List<string>>();

        private readonly int _maxLength = 100;

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

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
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
                    ClearErrors(nameof(Name));

                    if (Contact.Name.Length > _maxLength)
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
                return Contact.PhoneNumber;
            }
            set
            {
                if (value != Contact.PhoneNumber)
                {
                    Contact.PhoneNumber = value;
                    ClearErrors(nameof(PhoneNumber));

                    if (!Regex.IsMatch(Contact.PhoneNumber,
                        @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$") ||
                        Contact.PhoneNumber.Length > _maxLength)
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
                return Contact.Email;
            }
            set
            {
                if (value != Contact.Email)
                {
                    Contact.Email = value;
                    ClearErrors(nameof(Email));

                    if (!Regex.IsMatch(Contact.Email,
                        @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$") ||
                            Contact.Email.Length > _maxLength)
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

        public bool HasErrors => _propertyErrors.Any();

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
        /// Зажигает событие.
        /// </summary>
        /// <param name="prop">Название свойства,
        /// для которого зажигается событие.</param>
        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyErrors.GetValueOrDefault(propertyName, null);
        }

        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<string>());
            }

            _propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        public void ClearErrors(string propertyName)
        {
            if (_propertyErrors.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }
    }
}
