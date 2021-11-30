using System;

namespace AdaptLib.Models
{
    public class PositionBase
    {
        protected double Data;
        protected string m_Axis; 

        public string Degrees()
        {
            return $"{Data:##0.#########}{m_Axis}";
        }

        public string DegreesMinutes()
        {
            var degrees = Math.Floor(Data);
            var minutes = (Data - degrees) * 60;
            return $"{degrees:##0} {minutes:00.#########}'{m_Axis}";
        }

        public string DegreesMinutesSeconds()
        {
            var degrees = Math.Floor(Data);
            var temp = (Data - degrees) * 60;
            var minutes = Math.Floor(temp);
            var seconds = (temp - minutes) * 60;
            return $"{degrees} {minutes:00}'{seconds:00.#########}\"{m_Axis}";
        }
    }
}