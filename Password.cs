using System;
using System.Collections.Generic;
using System.Text;

namespace C_Programming_Example
{
    internal class Password
    {
        string letters { get; } = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm____----";
        string numbers_pow { get; } = "1234567890__--";
        string numbers { get; } = "1234567890";



        public int lenght { get; set => field = value > 0 ? value: 0; }
        bool only_letters;
        bool only_numbers;

        public Password(int lenght): this(lenght, true, true)
        {
            this.lenght = lenght;
        }

        public Password(int lenght, bool only_letters, bool only_numbers)
        {
            this.lenght = lenght;
            this.only_letters = only_letters;
            this.only_numbers = only_numbers;
        }

        public virtual string? Generate()
        {
            StringBuilder? password = new StringBuilder(capacity: lenght);
            Random random = new Random();

            if (only_letters && only_numbers)
            {
                for (int i = 0; i < lenght; i++)
                {
                    int norl = random.Next(1, 3);

                    if (norl == 1)
                        password.Insert(i, letters[random.Next(1, letters.Length)]);
                    else if (norl == 2)
                        password.Insert(i, numbers_pow[random.Next(1, numbers_pow.Length)]);
                }
            }

            else if (only_letters)
            {
                for (int i = 0; i < lenght; i++)
                {
                    password.Insert(i, letters[random.Next(1, letters.Length)]);
                }
            }
            else if (only_numbers)
            {
                for (int i = 0; i < lenght; i++)
                {
                    password.Insert(i, numbers[random.Next(1, numbers.Length)]);
                }
            }

            else
                password = null;

            return password?.ToString();
        }
    }
}
