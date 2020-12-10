using System;

namespace Algoritm_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 10, 5, 8, 7, 6, 4, 3, 2, 9 };

            Console.Write("Before : ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine("\n");

            Console.Write("After : ");
            int min;
            int index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                min = 9999;
                for (int j = i; j < list.Length; j++)
                {
                    if (min > list[j])
                    {
                        min = list[j];
                        index = j;
                    }
                }
                int temp = list[i];
                list[i] = list[index];
                list[index] = temp;
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]} ");
            }

        }
    }
}
