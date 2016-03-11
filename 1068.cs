/*
1068. Сумма
Ограничение времени: 2.0 секунды
Ограничение памяти: 64 МБ
Всё, что от вас требуется — найти сумму всех целых чисел, лежащих между 1 и N включительно.
Исходные данные
В единственной строке расположено число N, по модулю не превосходящее 10000.
Результат
Выведите целое число — ответ задачи.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1068
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (n < 1)
            {
                for (int i = n; i <= 1; i++)
                {
                    sum += i;
                }
            }
            if (n >= 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
            }
            Console.Write(sum);
        }
    }
}