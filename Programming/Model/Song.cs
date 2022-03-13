using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Song
    {
        private string _title;

        private int _durationInMinutes;

        private string _author;

        public string Title { get; set; }

        public string Author { get; set; }

        public int DurationInMinutes
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The duration cannot be negative");
                }

                _durationInMinutes = value;
            }
        }
    }
}
