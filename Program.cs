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
            int i = 0;
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
            int a = (int)Math.Pow(2, n), b=0;
            string [] arr = new string[a];

            arr[0] = "0";
            arr[1] = "1";
          //  arr[2] = arr[1];
          //  arr[3] = arr[0];
            while (arr[0].Length != n)
            {
               

                while (b == 0)
                {
                    
                    if (arr[i] == null)
                        {
                            b = i;
                        }
                    i++;
                }
                //b--;
                b = b * 2;
                int j = 1;
                for (i=b/2;i<b;i++)
                {
                    arr[i] = arr[i -j ];
                    j=j+2;

                }
                for ( i = 0; i < b; i++)
                {
                    if (i < b / 2)
                    {
                        arr[i] = "0" + arr[i];
                    }
                    else
                    {
                        arr[i] = "1" + arr[i];
                    }
                }


                //  gray(n, arr[], depth);
               
            }
            for (i = 0; i < a; i++)
            {
                Console.WriteLine(arr[i] + "  ");
            }
            Console.ReadKey();

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
