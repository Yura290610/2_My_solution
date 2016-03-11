using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Divide_the_number_of_bits_on
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number with 5 bits");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number > 99999) || (number < 10000))
            {
                Console.WriteLine("The number should be over than 10000 and less than 99999;");
            }
            else
            {
                int i = 1;
                while (number != 0)
                {
                    Console.WriteLine(i + " bit = " + number % 10);
                    number = number / 10;
                    i++;
                }
            }
        }
    }
}