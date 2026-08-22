using System;
using System.Collections.Generic;
using System.Text;

namespace C_Programming_Example
{
    internal static class Hack
    {
        static public void Start(string hackpassword, string password = "")
        {
            int counttry = 0;

            char[] numbers = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            if (hackpassword == password)
            {
                Console.WriteLine("Найден за " + counttry + " попыток");
            }
            else
            {
                if (password.Length == hackpassword.Length)
                {
                    Console.WriteLine(password);
                }
                else
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Start(hackpassword, password + numbers[i]);
                        counttry++;
                    }
                }
            }
        }
    }
}
