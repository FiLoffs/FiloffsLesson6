using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();

        }


        private static void task1()
        {
            int m = 5, n = 6, min = 0, max = 0;

            Random x = new Random();   
            int[,] MinMax = new int [m, n], minIndex = new int[m,n], maxIndex = new int[m,n];
            int[] row = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MinMax[i, j] = x.Next(100);
                    Console.Write("\t" + MinMax[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==========================");
            min = MinMax[0,0];
            for (int i = 0; i < m; i++)
            {
                //row[i] = MinMax[i, 0];
                for (int j = 0; j < n; j++)
                {

                    if (min > MinMax[i,j])
                    {
                        min = MinMax[i, j];
                    }
                }
                
            }
            max = MinMax[0, 0];
            for (int i = 0; i < m; i++)
            {
                //row[i] = MinMax[i, 0];
                for (int j = 0; j < n; j++)
                {

                    if (max < MinMax[i, j])
                    {
                        max = MinMax[i, j];
                    }
                }

            }
            Console.WriteLine($"минимальное значение = \t\t{min}");
            Console.WriteLine($"максимальное значение = \t{ max}");
            Console.WriteLine();            
        }


        private static void task2()
        {
            double[,] c = new double[10, 10];
            double sum = 0;
            Random x = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    c[i, j] = Convert.ToDouble(x.Next(10));
                    Console.Write(c[i, j] + "\t");
                    if (i==j)
                    {
                        sum += c[i, j];
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine($"сумма равна главной диагонали равна {sum} \n");
            Console.WriteLine("==========================\n");
        }
    }
}
