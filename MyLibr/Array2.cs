using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Array2
    {
        private int[,] arr;

        public Array2(int m, int n)
        {
            arr = new int[m, n];
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rand.Next(-100, 101);
                }
            }
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }

            return sum;
        }

        public int SumFor(int x)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j] > x ? arr[i, j] : 0;
                }
            }
            return sum;
        }
        public int Min
        {
            get
            {
                int min = int.MaxValue;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        min = arr[i, j] < min ? arr[i, j] : min;
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = int.MinValue;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        max = arr[i, j] > max ? arr[i, j] : max;
                    }
                }
                return max;
            }
        }

        public void MaxOut(out string x)
        {
            int t = int.MinValue;
            int a = 0;
            int b = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    /*t = arr[i, j] > t ? arr[i, j] : t;*/
                    if (t < arr[i, j])
                    {
                        t = arr[i, j];
                        a = i; b = j;
                    }
                }
            }
            x = $"Номер максимального элемента {a}, {b}.";
        }

        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
