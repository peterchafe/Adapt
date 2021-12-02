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
            base.Minimum = -90D;
            base.Maximum = 90D;
            m_Axis = value < 0 ? "S" : "N";
            Data = Math.Abs(value);
        }

        public override double Minimum => base.Minimum;

        public override double Maximum => base.Maximum;
        public string Axis => m_Axis;
    }
}