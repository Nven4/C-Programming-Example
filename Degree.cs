using System;
using System.Collections.Generic;
using System.Text;

namespace C_Programming_Example
{
    internal class Degree
    {
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

        public Degree(int hour) : this(hour, 0)
        {
            this.hour = hour;
        }

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
