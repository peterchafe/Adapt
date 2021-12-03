using System;

namespace AdaptLib.Models
{
    public class Latitude : PositionBase
    {
        public static double Minimum = -90D;
        private const double Maximum = 90D;

        public Latitude()
            : this(0D)
        {
        }

        public Latitude(double value)
        {
            m_Axis = value < 0 ? "S" : "N";
            Data = Math.Abs(value);
        }

        public string Axis => m_Axis;

        public static bool TryParse(string value, out Latitude latitude)
        {
            latitude = new Latitude();

            if (double.TryParse(value, out double result))
            {
                if (!IsValid(result))
                {
                    latitude = new Latitude(0D);
                    return false;
                }

                latitude = new Latitude(result);
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