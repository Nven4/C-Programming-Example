using System;
using System.Collections.Generic;
using System.Text;

namespace C_Programming_Example
{
    internal class Day
    {
        int day { get; set; }
        int month { get; set; }
        long year {  get; set;  }

        int res_day
        {  
            get;
            set
            {
                if (value < 0 || value > 6)
                    value = -1;
                else
                    field = value;
            }
        }

        /// <summary>
        /// В формате для 14 августа 2026 года: 14/8/2026 день, номер месяца и год
        /// /// </summary>
        /// <param name="data"></param>
        public Day(string data)
        {
            var data_split = data.Split("/");
            day = int.Parse(data_split[0]);
            month = int.Parse(data_split[1]);
            year = int.Parse(data_split[2]);
        }

        public Day(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public double Callculate()
        {
            if (month < 3)
            {
                month += 12;
                year--;
            }

            double k = year % 100;
            double j = year / 100;
            res_day = (int)(day + 13 * (month + 1) / 5 + k + k / 4 + j / 4 + 5 * j) % 7;

            return res_day;
        }

        public static explicit operator string(Day day)
        {
            return day.res_day switch
            {
                0 => "Суббота",
                1 => "Воскременье",
                2 => "Понедельник",
                3 => "Вторник",
                4 => "Среда",
                5 => "Четверг",
                6 => "Пятница",
                _ => "Ошибка дня недели"
            };
        }
    }
}
