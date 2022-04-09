using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _durationInMinutes;

        private int _yearOfRelease;

        private double _rating;

        public Movie()
        {
        }

        public Movie(int durationInMinutes, int yearOfRelease, 
            double rating, string title, string genre) 
        {
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Title = title;
            Genre = genre;
        }

        public string Title { get; set; }

        public string Genre { get; set; }

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

        public int YearOfRelease
        {
            get
            {
                return _yearOfRelease;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(YearOfRelease));
                _yearOfRelease = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
