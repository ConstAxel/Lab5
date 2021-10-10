using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4App4
{
    class Program
    {
        static void Main(string[] args)
        {/*Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество   нечетных положительных элементов, стоящих на четных местах.*/
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            Console.WriteLine("Массив из 20 элементов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($"Порядковый номер-{i + 1} :\t{array[i]}\n");
            }
            Console.WriteLine();
            Console.WriteLine("Элементы удовлетворяющие условию");
            Console.WriteLine("По порядковому номеру");
            int k = 0; //количество
            for (int i = 1; i < n; i+=2)
            {
                if (array[i] >0)
                {
                    if (array[i]%2!=0)
                    {
                        k++;
                        Console.Write($" Порядковый номер-{i + 1}:\t{array[i]}\n");
                    }
                }
            }
            Console.WriteLine($"{k}-Количество");
            Console.ReadKey();

        }
    }
}
