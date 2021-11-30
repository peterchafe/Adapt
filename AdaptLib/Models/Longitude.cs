using System;

namespace AdaptLib.Models
{
    public sealed class Longitude : PositionBase
    {
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
    }
}