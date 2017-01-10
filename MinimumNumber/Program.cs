using System;
/// <summary>
/// В последовательности целых чисел найдите минимальное число и количество его повторений.
/// </summary>
namespace MinimumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] n = new int[10];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = r.Next(7);
            }
            Print(n);
            Array.Sort(n);
            Print(n);
            int min = n[0];
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] < min)
                {
                    min = n[i];
                }
            }

            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (min == n[i])
                {
                    count++;
                }
            }
            Console.WriteLine("min: {0}, count: {1}", min, count);
            Console.ReadLine();
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
