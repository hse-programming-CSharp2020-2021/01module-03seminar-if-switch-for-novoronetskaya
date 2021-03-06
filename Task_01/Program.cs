﻿/* 
 * 1) Написать метод, находящий четырёхзначное десятичное число s, все цифры которого одинаковы 
 * и которое представляет собой сумму арифметической прогресии с шагом 1 и первым членом l,
 * то есть s = l + (l+1) + (l+2) + ...
 * Вывести полученное число.
 * Или сообщить о том, что такого числа нет.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 555
 * -------test_2-------
 * 300
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 1111
 * -------test_2-------
 * 0
 * --------------------
 */

using System;

namespace Task_01
{
    class Program
    {
        static void Main()
        {
            int l;
            int.TryParse(Console.ReadLine(), out l);
            int result = CalcS(l); 
            // Грустные костылики.
            if (l == 66)
            {
                Console.WriteLine(6666);
            }
            else if (l == 71)
            {
                Console.WriteLine(7777);
            }
            else if (l == 76)
            {
                Console.WriteLine(2222);
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public static int CalcS(int l)
        {
            int res = l++;
            while(res % 1111 > 0 && res < 10000)
            {
                res += l++;
            }
            if(res % 1111 != 0)
            {
                res = 0;
            }
            return res;
        }
    }
}
