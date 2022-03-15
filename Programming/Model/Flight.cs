using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Flight
    {
        private int _flightTimeInMinutes;

        public Flight()
        {
        }

        public Flight(int flightTimeInMinutes, string departurePoint, string destination)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            DeparturePoint = departurePoint;
            Destination = destination;
        }

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
