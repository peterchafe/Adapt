using System;

namespace AdaptLib.Models
{
    public class PositionBase
    {
        private const string Degree = "°";
        private const string Minutes = "'";
        private const string Seconds = "\"";

        protected double Data;
        protected string m_Axis; 

        public virtual double Minimum { get; set; }

        public virtual double Maximum { get; set; }

        public string Degrees()
        {
            return $"{Data:##0.#########}{Degree}{m_Axis}";
        }

        public string DegreesMinutes()
        {
            var degrees = Math.Floor(Data);
            var minutes = (Data - degrees) * 60;
            return $"{degrees:##0}{Degree}{minutes:00.#########}{Minutes}{m_Axis}";
        }

        public string DegreesMinutesSeconds()
        {
            var degrees = Math.Floor(Data);
            var temp = (Data - degrees) * 60;
            var minutes = Math.Floor(temp);
            var seconds = (temp - minutes) * 60;
            return $"{degrees}{Degree}{minutes:00}{Minutes}{seconds:00.#########}{Seconds}{m_Axis}";
        }
    }
}