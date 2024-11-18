using System;

namespace FractionSample
{
    public class Fraction
    {
        // Private attributes for numerator and denominator
        private int _top;
        private int _bottom;

        // Constructor with no parameters: initializes to 1/1
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // Constructor with one parameter: initializes to the number as top/1
        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        // Constructor with parameters: initializes to top/bottom
        public Fraction(int top, int bottom)
        {
            if (bottom == 0)
                throw new ArgumentException("Denominator cannot be zero");
            _top = top;
            _bottom = bottom;
        }

        // Getters and setters for the top and bottom values
        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public int Bottom
        {
            get { return _bottom; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("The denominator can't be zero");
                _bottom = value;
            }
        }

        // Method to return the fraction as a string (e.g., "3/4")
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        // Method to return the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }
    }
}
