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
                Validator.AssertValueInRange(value, 2, 5, nameof(Mark));
                _mark = value;
            }
        }
    }
}
