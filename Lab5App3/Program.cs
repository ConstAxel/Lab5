using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5App3
{
    class Program
    {
        static void Main(string[] args)
        {/*Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.*/
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            Console.WriteLine("Массив из 10 элементов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($"{array[i]}\t");
            }
            for (int i = 0; i < n/2-1; i++)
            {
                for (int j = i+1; j < n/2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j]= t;
                    }
                }
            }
            for (int i = n/2; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сортировка:5 первых элементов по возрастанию, вторые 5 по убыванию:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.ReadKey();
        }
    }
}
