using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5App1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.*/
            const int n = 7;
            int[] array = new int[n];
            double s = 0;
            Console.WriteLine($"Введите элементы массива из 7 элементов:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент:");
                array[i]= int.Parse(Console.ReadLine());
                s += array[i];
            }
            double sa = s / n;
            Console.WriteLine($"Сумма введенных элементов:{s}");
            Console.WriteLine($"Среднее арифметическое элементов:{sa:f2}");
            Console.ReadKey();
        }
    }
}

