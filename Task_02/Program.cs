/*
 * 2) Написать метод, преобразующий число переданное в качестве параметра в число, 
 * записанное теми же цифрами, но идущими в обратном порядке. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1024 
 * -------test_2-------
 * 120
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4201
 * -------test_2-------
 * 21
 * --------------------
 */

using System;

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(Reverse(x));
        }

        public static int Reverse(int x)
        {
            int result = 0;
            while(x > 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }
            return result;
        }
    }
}
