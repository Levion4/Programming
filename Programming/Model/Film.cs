using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Film
    {
        private string _title;

        private int _durationInMinutes;

        private int _yearOfRelease;

        private string _genre;

        private double _rating;

        public string Title { get; set; }

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

        public int YearOfRelease
        {
            get
            {
                return _yearOfRelease;
            }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("The year of release of the film should be from 1900 to the current year");
                }

                _yearOfRelease = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("The rating should be in the range from 0 to 10");
                }

                _rating = value;
            }
        }
    }
}
