﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public class MainVM: INotifyPropertyChanged
    {
        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts =
            new ObservableCollection<Contact>();

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _currentContact = new Contact();

        /// <summary>
        /// Клон контакта.
        /// </summary>
        private Contact _cloneContact;

        /// <summary>
        /// Изначальный контакт.
        /// </summary>
        private Contact _initialContact;

        /// <summary/>
        /// Отвечает за активацию элементов.
        /// </summary>
        private bool _isActivated = false;

        /// <summary>
        /// Отвечает за активацию кнопок удаления и изменения.
        /// </summary>
        private bool _isActivatedButtons = true;

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Команда применения контакта.
        /// </summary>
        private RelayCommand _applyCommand;

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        private RelayCommand _removeCommand;

        /// <summary>
        /// Команда изменения контакта.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Хранит событие на изменение.
        /// Зажигается при изменении данных контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает нужно ли активировать элементы. 
        /// Задается только во время инициализации.
        /// </summary>
        public bool IsActivated
        {
            get 
            { 
                return _isActivated; 
            }
            private set
            {
                _isActivated = value;
                OnPropertyChanged(nameof(IsActivated));
            }
        }

        /// <summary>
        /// Возвращает и задает нужно ли активировать
        /// кнопки удаления и изменения. 
        /// Задается только во время инициализации.
        /// </summary>
        public bool IsActivatedButtons
        {
            get
            {
                return _isActivatedButtons;
            }
            private set
            {
                _isActivatedButtons = value;
                OnPropertyChanged(nameof(IsActivatedButtons));
            }
        }

        /// <summary>
        /// Команда на выполнение добавления контакта.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(obj =>
                    {
                        CurrentContact = null;
                        CurrentContact = new Contact();
                        IsActivated = true;
                        IsActivatedButtons = true;
                    }));
            }
        }

        /// <summary>
        /// Команда на выполнение применения контакта.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ??
                    (_applyCommand = new RelayCommand(obj =>
                    {
                        IsActivated = false;
                        IsActivatedButtons = false;

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
                    }));
            }
        }

        /// <summary>
        /// Команда на выполнение редактирования контакта.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                    (_editCommand = new RelayCommand(obj =>
                    {
                        _cloneContact = (Contact)CurrentContact.Clone();
                        _initialContact = CurrentContact;
                        CurrentContact = _cloneContact;

                        if(CurrentContact != null && Contacts.Count > 0)
                        {
                            IsActivated = true;
                            IsActivatedButtons = true;
                        }        
                    },
                    (obj) => CurrentContact != null));
            }
        }

        /// <summary>
        /// Команда на выполнение удаления контакта.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(obj =>
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
                    },
                    (obj) => CurrentContact != null));
            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                if (value != _contacts)
                {
                    _contacts = value;
                    OnPropertyChanged(nameof(Contacts));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает текущий контакт.
        /// </summary>
        public Contact CurrentContact
        {
            get
            {
                return _currentContact;
            }
            set
            {
                if (value != _currentContact)
                {
                    _currentContact = value;
                    OnPropertyChanged(nameof(CurrentContact));
                    IsActivated = false;
                    IsActivatedButtons = false;
                }
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
