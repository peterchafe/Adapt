using System;

namespace AdaptLib.Models
{
    public sealed class Longitude : PositionBase
    {
        public static double Minimum = -180D;
        private const double Maximum = 180D;

        public Longitude()
        : this(0D)
        {
        }

        public Longitude(double value)
        {
            m_Axis = value < 0 ? "W" : "E";
            Data = Math.Abs(value);
        }

        public string Axis => m_Axis;

        public static bool TryParse(string value, out Longitude longitude)
        {
            longitude = new Longitude();

            if (double.TryParse(value, out double result))
            {
                if (!IsValid(result))
                {
                    longitude = new Longitude(0D);
                    return false;
                }

                longitude = new Longitude(result);
                return true;
            }

            return false;
        }

        private static bool IsValid(double value)
        {
             return value >= Minimum && value <= Maximum;
        }
    }
}