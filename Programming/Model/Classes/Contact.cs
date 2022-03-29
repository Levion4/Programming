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

        public Contact()
        {
        }

        public Contact(string name, string number, string city)
        {
            Number = number;
            Name = name;
            City = city;
        }

        public string Name { get; set; }

        public string City { get; set; }

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
