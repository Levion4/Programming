using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Model;
using ViewModel.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<ContactVM> _contacts =
            new ObservableCollection<ContactVM>();

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        private ContactVM _currentContact;

        /// <summary>
        /// Клон контакта.
        /// </summary>
        private ContactVM _cloneContact;

        /// <summary>
        /// Изначальный контакт.
        /// </summary>
        private ContactVM _initialContact;

        /// <summary/>
        /// Отвечает за доступность элементов.
        /// </summary>
        private bool _isAvailable = false;

        /// <summary>
        /// Возвращает и задает доступность элементов. 
        /// Задается только во время инициализации.
        /// </summary>
        public bool IsAvailable
        {
            get
            {
                return _isAvailable;
            }
            private set
            {
                _isAvailable = value;
                OnPropertyChanged(nameof(IsAvailable));
            }
        }

        [RelayCommand]
        private void Add()
        {
            CurrentContact = null;
            CurrentContact = new ContactVM(new Contact());
            IsAvailable = true;
        }

        [RelayCommand]
        private void Apply()
        {
            IsAvailable = false;

            if (_cloneContact != null)
            {
                int index = Contacts.IndexOf(_initialContact);
                Contacts[index] = _cloneContact;
                _cloneContact = null;
                CurrentContact = Contacts[index];

                return;
            }

            if (!Contacts.Contains(CurrentContact))
            {
                Contacts.Add(CurrentContact);
                return;
            }
        }

        [RelayCommand(CanExecute = nameof(CheckingCurrentContactForNull))]
        private void Remove()
        {
            if (Contacts.Count > 1)
            {
                int index = Contacts.IndexOf(CurrentContact);

                if (index == 0)
                {
                    CurrentContact = Contacts[index + 1];
                }
                else
                {
                    CurrentContact = Contacts[index - 1];
                }

                Contacts.RemoveAt(index);
            }
            else
            {
                Contacts.Remove(CurrentContact);
            }
        }

        [RelayCommand(CanExecute = nameof(CheckingCurrentContactForNull))]
        private void Edit()
        {
            _cloneContact = (ContactVM)CurrentContact.Clone();
            _initialContact = CurrentContact;
            CurrentContact = _cloneContact;

            if (CurrentContact != null && Contacts.Count > 0)
            {
                IsAvailable = true;
            }
        }

        /// <summary>
        /// Сохраняет данные.
        /// </summary>
        public void Save()
        {
            ContactSerializer.SaveToFile(Contacts);
        }

        /// <summary>
        /// Загружает данные.
        /// </summary>
        public void Load()
        {
            Contacts = ContactSerializer.LoadFromFile();
        }

        /// <summary>
        /// Проверяет выбранных контакт на null.
        /// </summary>
        /// <returns>Возвращает false,
        /// если контакт равен null, иначе true.</returns>
        private bool CheckingCurrentContactForNull()
        {
            if (CurrentContact != null)
            {
                return true;
            }

            return false;
        }
    }
}
