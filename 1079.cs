/*
1079. Максимум
Ограничение времени: 2.0 секунды
Ограничение памяти: 64 МБ
Рассмотрим последовательность чисел ai, i = 0, 1, 2, …, удовлетворяющих следующим условиям:
a0 = 0
a1 = 1
a2i = ai
a2i + 1 = ai + ai + 1
для каждого i = 1, 2, 3, … .
Напишите программу, которая для заданного значения n находит максимальное среди чисел a0, a1, …, an.
Исходные данные
Входные данные состоят из нескольких тестов (не более 10). Каждый тест представляет собой строку, в которой записано целое число n (1 ≤ n ≤ 99 999). В последней строке входных данных записано число 0.
Результат
Для каждого n во вводе выведите соответствующее максимальное значение.*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1079
{

    class Program
    {



        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[,] array_of_values = { { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 } };

            while (n != 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (n == 1)
                    {
                        Console.WriteLine(1);
                        break;
                    }
                    if (n == 2)
                    {
                        Console.WriteLine(1);
                        break;
                    }
                    if (array_of_values[0, i] == n)
                    {
                        Console.WriteLine(array_of_values[1, i]);
                        break;
                    }
                    else
                    {
                        if (array_of_values[0, i] == -1)
                        {
                            /*long max = 0;
                            long current_amount;
                            array_of_values[0, i] = n;
                            if (n%2 == 0)  n = n - 1;
                            for (int j = 3; j <= n; j++)
                            {
                                current_amount = find_max(j);
                                if (current_amount > max) max = current_amount;
                            }
                            array_of_values[1, i] = max;
                            Console.WriteLine(max);
                            break;*/
                            long max = 0;
                            long current_amount;
                            array_of_values[0, i] = n;
                            if (n % 2 == 0) n = n - 1;
                            int l = 0;
                            for (int j = n; j >= n / 3; j--)
                            {
                                current_amount = find_max(j);
                                if (current_amount > max)
                                {
                                    max = current_amount;
                                    l++;
                                }
                                //if (l > 5) break;
                            }

                            array_of_values[1, i] = max;
                            Console.WriteLine(max);
                            break;
                        }
                    }
                }


                n = Convert.ToInt32(Console.ReadLine());
            }

        }
        public static Int32 find_max(int k)
        {
            Int32 sum = 0;
            if (k == 0) { return 0; }
            if (k == 1) { return 1; }
            if (k % 2 == 0)
            {
                sum = sum + find_max(k / 2);
                return sum;
            }
            else
            {
                sum = sum + find_max((k - 1) / 2) + find_max((k - 1) / 2 + 1);
                return sum;
            }

        }

    }
}