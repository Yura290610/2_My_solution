using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrayValues = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayValues[i] = i + 1;
            }

            Console.Write("\n");

            print(arrayValues, n);
            while (Search(arrayValues, n))
            {

                print(arrayValues, n);
            }

        }
        static bool Search(int[] arrayValues, int n)
        {
            int right = 0;
            int left = 0;
            int r = n - 2;
            while ((arrayValues[r] >= arrayValues[r + 1]) && (r > -1))
            {
                r--;
                if (r < 0) return false;
            }
            right = r;
            int l = n - 1;
            while ((arrayValues[right] >= arrayValues[l]) && (l >= 0))
            {
                l--;
            }
            left = l;
            change(arrayValues, left, right);

            left = right + 1;
            right = n - 1;
            while (left < right)
            {

                change(arrayValues, left, right);
                left++;
                right--;
            }
            return true;
        }
        static void change(int[] ar, int j, int k)
        {
            int temp = ar[j];
            ar[j] = ar[k];
            ar[k] = temp;
        }

        static int num = 0;

        static void print(int[] ar, int n)
        {
            num++;
            Console.Write(num + ") ");
            for (int p = 0; p < n; p++)
            {
                Console.Write(ar[p] + " ");
            }
            Console.Write("\n\n");
        }
    }


}