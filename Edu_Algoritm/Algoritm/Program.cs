using System;

namespace Algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 10, 1, 5, 8, 7, 6, 4, 3, 2, 9 };

            // WriteBefore(list);

            // WriteResult(SelectionSort(list));

            // WriteResult(BubbleSort(list));

            // WriteResult(InsertSort(list));

            QuickSort(list, 0, list.Length - 1);

            for (int i = 0; i < list.Length; i++)
                Console.Write(list[i] + " ");

        }
        static void WriteBefore(int[] list)
        {
            Console.Write("Before : ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine(" ");
        }

        static void WriteResult(int[] list)
        {
            if (list == null)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine(" ");
            }

        }

        static int[] SelectionSort(int[] sortList)
        {
            int[] list = sortList;
            int min, index = 0;
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
            Console.Write("Selection Sort Result : ");
            return list;
        }

        static int[] BubbleSort(int[] sortList)
        {
            int[] list = sortList;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            Console.Write("Bubble Sort Result : ");
            return list;
        }

        static int[] InsertSort(int[] sortList)
        {
            int[] list = sortList;
            for (int i = 0; i < list.Length - 1; i++)
            {
                int j = i;
                while (j >= 0 && list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                    j--;
                }
            }
            Console.Write("Insert sort Result : ");
            return list;
        }


        static void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int q = Partition(array, start, end);
                QuickSort(array, start, q - 1);
                QuickSort(array, q + 1, end);
            }
        }

        static int Partition(int[] array, int start, int end)
        {
            int key = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] <= array[end])
                {
                    Swap(array, key, i);
                    key++;
                }
            }
            Swap(array, key, end);
            return key;
        }

        static void Swap(int[] array, int beforeIndex, int foreIndex)
        {
            var tmp = array[beforeIndex];
            array[beforeIndex] = array[foreIndex];
            array[foreIndex] = tmp;
        }
    }
}
