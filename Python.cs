using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace C_Programming_Example
{
    internal static class Python
    {
        public static string[,] field; 

        public static void print(string sep, params string[] strings)
        {
            Console.Write(string.Join(sep, strings));
        }

        public static void startgame()
        {
            Random random = new Random();

            field = new string[,]
            {
                {"1|", "0", "0", "0", "0", "0", "|"},
                {"2|", "0", "0", "0", "0", "0", "|"},
                {"3|", "0", "0", "0", "0", "0", "|"},
                {"4|", "0", "0", "0", "0", "0", "|"},
                {"5|", "0", "0", "0", "0", "0", "|"}
            };

            for(int i = 0; i < field.GetLength(0); i++)
            {
                int count = 0;

                for(int j = 1; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == "|")
                        continue;

                    int rand = random.Next(0,2);

                    if(rand == 1)
                        count++;

                    field[i, j] = Convert.ToString(rand);
                }
                field[i, 0] = Convert.ToString(count)+"|";
            }

            GetHoryzCount(field);

            for (int i = 0;  i < field.GetLength(0); i++)
            {
                for(int j = 0;  j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void GetHoryzCount(string[,] field)
        {
            Console.Write("  ");

            int count = 1;
            int horyzcount = 0;
            for(int i = 0; count < 6; i++)
            {
                if (i == 5)
                {
                    i = 0;
                    count++;
                    Console.Write(horyzcount);
                    horyzcount = 0;
                }

                if (field[i, count] == "1")
                    horyzcount++;
            }
            Console.WriteLine();
        }
    }
}
