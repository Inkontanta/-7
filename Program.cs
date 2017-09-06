using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, depth=0;
            bool ok = false;
            while (!ok)                 //проверка ввода 1-ой переменной m
            {
                try
                {
                    Console.WriteLine("Введите длину кодовых слов:");
                    n = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Число введено неверно, повторите ввод");
                    ok = false;
                }
            }
            int[] arr = new int[(int)Math.Pow(2, n)];
            
            gray(n, arr[], depth);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + "  ");
            }

        }

        int gray(int n, int[] arr, int depth)
        {
            int i, t = (1 << (depth - 1));

            if (depth == 0)
                arr[0] = 0;

            else
            {
                //массив хранит десятичные записи двоичных слов
                for (i = 0; i < t; i++)
                    arr[t + i] = arr[t - i - 1] + (1 << (depth - 1));
            }
            if (depth != n)
                gray(n, arr, depth + 1);

            return 0;
        }
    

            
        }
    }
}
