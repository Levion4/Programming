using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Flight
    {
        private string _departurePoint;

        private string _destination;

        private int _flightTimeInMinutes;

        public string DeparturePoint { get; set; }

        public string Destination { get; set; }

        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The flight time cannot be negative");
                }

                _flightTimeInMinutes = value;
            }
        }
    }
}
