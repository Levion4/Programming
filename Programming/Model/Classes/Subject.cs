using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _mark;

        public Subject()
        {
        }

        public Subject(string teacher, string name, int mark)
        {
            Teacher = teacher;
            Name = name;
            Mark = mark;
        }

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
                    throw new ArgumentException(
                        $"The mark should be in the range from 2 to 5, " +
                        $"but was {value}");
                }

                _mark = value;
            }
        }
    }
}
