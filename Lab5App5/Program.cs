using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5App5
{
    class Program
    {
        static void Main(string[] args)
        {/*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:

        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1*/
            Console.Write("Введите значение целочисленное N:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int[,] t = new int[n, m];

            for (int i = 0; i < n; i += 2)
            {
                for (int j = 0; j < m; j += 2)
                {
                    t[i, j] = 1;
                }
            }
            for (int i = 1; i < n; i+=2)
            {
                for (int j = 0; j < m; j+=2)
                {
                    t[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i += 2)
            {
                for (int j = 1; j < m; j += 2)
                {
                    t[i, j] = 0;
                }
            }
            for (int i = 1; i < n; i += 2)
            {
                for (int j = 1; j < m; j += 2)
                {
                    t[i, j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
