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
                {"1|", "0", "0", "0", "0", "0"},
                {"2|", "0", "0", "0", "0", "0"},
                {"3|", "0", "0", "0", "0", "0"},
                {"4|", "0", "0", "0", "0", "0"},
                {"5|", "0", "0", "0", "0", "0"}
            };

            for(int i = 0; i < field.GetLength(0); i++)
            {
                for(int j = 1; j < field.GetLength(1); j++)
                {
                    field[i, j] = Convert.ToString(random.Next(0, 2));
                }
            }

            Console.WriteLine("  12345");

            for (int i = 0;  i < field.GetLength(0); i++)
            {
                for(int j = 0;  j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
