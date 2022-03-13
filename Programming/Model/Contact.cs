using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Contact
    {
        private string _name;

        private string _number;

        private string _city;

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
                    throw new ArgumentException("The number must contain 11 digits");
                }

                if (!int.TryParse(value, out var x))
                {
                    throw new ArgumentException("The number must contain only digits");
                }

                _number = value;
            }

        }
    }
}
