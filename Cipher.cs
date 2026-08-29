using System;
using System.Collections.Generic;
using System.Text;

namespace C_Programming_Example
{
    public abstract class Cipher
    {
        protected virtual string word { get; set; }

        public Cipher()
        {
            word = "";
        }

        public Cipher(string word)
        {
            this.word = word;
        }

        public abstract string Coding();
    }

    public class Caesar: Cipher
    {
        public string result = "";
        protected int step { get; set => field = value > 0 ? value: 0; }
        public Caesar(string word, int step = 0): base(word)
        {
            this.step = step;
        }

        public override string Coding()
        {
            for (int i = 0; i < word.Length; i++)
            {
                result += (char)((int)word[i] + step);
            }

            return result;
        }

        public static explicit operator string(Caesar cl)
        {
            string res = "";
            for (int i = 0; i < cl.result.Length; i++)
            {
                res += (char)((int)cl.result[i] - cl.step);
            }

            return res;
        }
    }
}
