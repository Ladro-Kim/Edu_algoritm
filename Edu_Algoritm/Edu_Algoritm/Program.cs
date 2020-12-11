using System;

namespace Edu_Algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 10, 8, 2, 5, 4, 6, 7, 9, 1, 3 };
            WriteBefore(list);
            SelectionSort(list);
            BubbleSort(list);
        }

        static void WriteBefore(int[] list)
        {
            Console.Write("Before : ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
                if (i == list.Length- 1 )
                {
                    Console.WriteLine();
                }
            }
        }

        static void WriteAfter(string name, int[] list)
        {
            Console.Write($"After {name} : ");
            for (int i= 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

        }


        static void SelectionSort(int[] sortList)
        {
            int[] list = sortList;
            int min;
            int index = 0;

            for (int i = 0; i < list.Length; i++)
            {
                min = int.MaxValue;
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
            WriteAfter("Selection Sort", list);
        }

        static void BubbleSort(int[] sortList)
        {
            int[] list = sortList;

            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1 - i; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            WriteAfter("Bubble Sort", list);
        }

    }
}
