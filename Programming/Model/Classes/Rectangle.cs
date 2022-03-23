using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Rectangle
    {
        private double _length;

        private double _width;

        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color)
        {
            Color = color;
            Width = width;
            Length = length;
        }

        public string Color { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
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
                if (value <= 0)
                {
                    throw new ArgumentException("The width cannot be negative");
                }

                _width = value;
            }
        }
    }
}
