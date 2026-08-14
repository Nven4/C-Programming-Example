using System;
using System.Collections.Generic;
using System.Text;

namespace C_Programming_Example
{
    /// <summary>
    /// Этот класс для нахождения градусов между сстрелками на часах
    /// </summary>
    internal class Degree
    {
        public int big { get; private set; } = null
        public int small { get; private set; } = null

        int hour
        {
            get;
            init => field = value > 12 ? 12 : value;
        } = 12;
        int minute
        {
            get;
            init => field = value > 60 ? 60 : value;
        } = 0;

        /// <summary>
        /// Принимает стрелку часа на часах
        /// </summary>
        /// <param name="hour"></param>
        public Degree(int hour) : this(hour, 0)
        {
            this.hour = hour;
        }
        /// <summary>
        /// Принимает стрелку часа и стрелку минут
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        public Degree(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }

        public void Deconstruct(out double result)
        {
            double hour_degree = (hour * 30) + (minute * 0.5);
            double minute_degree = 6 * minute;
            Console.WriteLine(hour_degree);
            Console.WriteLine(minute_degree);
            result = Math.Abs(hour_degree - minute_degree);
        }
    }
}
