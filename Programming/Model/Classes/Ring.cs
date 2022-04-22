using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _outerRadius;

        private double _innerRadius;

        public Ring()
        {
        }

        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        public Point2D Center { get; set; }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, InnerRadius, 
                    double.PositiveInfinity, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, OuterRadius,
                    nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - 
                    Math.PI * Math.Pow(InnerRadius, 2);
            }
        }
    }
}
