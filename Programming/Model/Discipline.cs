using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Discipline
    {
        private string _teacher;

        private int _mark;

        private string _name;

        public string Teacher { get; set; }

        public string Name { get; set; }

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 2 || value > 5)
                {
                    throw new ArgumentException("The mark should be in the range from 2 to 5");
                }

                _mark = value;
            }
        }
    }
}
