using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _durationInMinutes;

        public Song()
        {
        }

        public Song(int durationInMinutes, string title, string author)
        {
            DurationInMinutes = durationInMinutes;
            Title = title;
            Author = author;
        }

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
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }
    }
}
