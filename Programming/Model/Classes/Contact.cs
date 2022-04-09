using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _number;

        private string _name;

        private string _surname;

        public Contact()
        {
        }

        public Contact(string name, string surname, string number, string city)
        {
            Number = number;
            Name = name;
            Surname = surname;
            City = city;
        }

        public string City { get; set; }

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            } 
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        $"The number must contain 11 digits, " +
                        $"but was {value.Length}");
                }

                if (!int.TryParse(value, out var x))
                {
                    throw new ArgumentException(
                        $"The number must contain only digits");
                }

                _number = value;
            }
        }
    }
}
