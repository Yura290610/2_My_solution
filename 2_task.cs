using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_task
{
    class Program
    {
        static int num = 0;
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (k != n + 1)
            {
                num++;
                Console.Write(num + ") ");

                for (int i = 0; i < n - k; i++)
                {
                    Console.Write('0');
                }
                for (int i = 0; i < k; i++)
                {
                    Console.Write('1');
                }
                Console.Write('\n');
                k++;
            }
        }
    }
}