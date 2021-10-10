using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5App6
{
    class Program
    {
        static void Main(string[] args)
        {/*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры.
         Проверить, является ли введенная с клавиатуры матрица магическим квадратом. Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.*/
            Console.Write("Введите значение целочисленное N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int[,] t = new int[n, m];
            Console.Write($"Введите элементы массива NхN:{n}х{m}\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }
            int si1 = 0;//сумма по первой строке для сравнения(cтолбцоа/строк/диагоналей)
            for (int j = 0; j < n; j++)
            {
                int i= 0;
                si1 += t[i, j];
            }
            Console.WriteLine($"Сумма для проверки:\t{si1}");
            for (int i = 0; i < n; i++)
            {
                int sa = 0;//сумма по строкам
                for (int j = 0; j < n; j++)
                {
                    sa += t[i, j];
                }
                Console.WriteLine($"Сумма по строкам:\t{sa}");
                if (sa == si1)
                {
                    //true
                }
                else
                {
                    //false
                }

            }
            for (int j = 0; j < n; j++)
            {
                int sb = 0;//сумма по столбцам
                for (int i = 0; i < n; i++)
                {
                    sb += t[i, j];
                }
                Console.WriteLine($"Сумма по столбцам:\t{sb}");
                if (sb == si1)
                {
                    //true
                }
                else
                {
                    //false
                }

            }
            //Сумма по диагоналям
            int sd1 = 0;//сумма первой диагонали
            for (int i = 0; i < n; i++)
            {
                int j = i;
                sd1 += t[i, j];
            }
            Console.WriteLine($"Сумма по диагонали 1:\t{sd1}");
            int sd2 = 0;// сумма диагоналей
            for (int i = 0; i < n; i++)
            {
                int j = n -1 - i;
                sd2 += t[i, j];
            }
            Console.WriteLine($"Сумма по диагонали 2:\t{sd2}");

            if (sd1 == si1)
            {
                Console.WriteLine("Матрица - магический квадрат");
            }
            else if (sd2 == si1)
            {
                Console.WriteLine("Матрица - магический квадрат");
            }
            else
            {
                Console.WriteLine("Матрица Не магический квадрат");
            }
            Console.ReadKey();
        }
    }
}
