using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5App2
{
    class Program
    {
        static void Main(string[] args)
        { /*Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.*/
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            Console.WriteLine("Массив из 15 элементов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next (0,50);
                Console.WriteLine($"{i})Элемент:\t{array[i]}");

            }
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
                else if (a < min)
                {
                    min = a;
                }
            }
            int sum = min + max;
            Console.WriteLine($"Максимальный элемент:{max}");
            Console.WriteLine($"Минимальный элемент:{min}");
            Console.WriteLine($"Сумма минимального и максимального:{sum}");
            Console.ReadKey();
        }
    }
}