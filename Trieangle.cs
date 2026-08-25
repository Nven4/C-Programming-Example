using System;
using System.Collections.Generic;
using System.Text;

namespace C_Programming_Example
{
    internal class Trieangle
    {
        static class Repeat
        {
            public static string String(string str, int lenght)
            {
                string res = "";
                do
                {
                    res += str;
                } while (res.Length != lenght * str.Length);

                return res;
            }
        }

        int lenght { get; init => field = value > 0 ? value : 1; } = 1;
        public char symbol {private get; set; }
        public Trieangle(int lenght):this(lenght, '*')
        {
            this.lenght = lenght;
        }

        public Trieangle(int lenght , char symbol)
        {
            this.lenght = lenght;
            this.symbol = symbol;
        }

        public void GenTriangle()
        {
            Console.WriteLine(Repeat.String(" ", lenght + 1) + symbol);
            for (int i = 1, j = lenght; i <= lenght; i++, j--)
            {
                Console.WriteLine(Repeat.String(" ", j) + symbol + Repeat.String(" ", i * 2 - 1) + symbol);
            }
            Console.WriteLine(Repeat.String(symbol + " ", lenght + 2));
        }
    }
}
