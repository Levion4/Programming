using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Rectangle
    {
        private double _length;

        private double _width;

        private string _color;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The length cannot be negative");
                }

                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The width cannot be negative");
                }

                _width = value;
            }
        }

        public string Color { get; set; }
    }
}
