using System;

namespace AdaptLib.Models
{
    public class Latitude : PositionBase
    {
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
    }
}