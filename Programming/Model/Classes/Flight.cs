using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeInMinutes;

        public Flight()
        {
        }

        public Flight(int flightTimeInMinutes, string departure, string destination)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            Departure = departure;
            Destination = destination;
        }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }
    }
}
