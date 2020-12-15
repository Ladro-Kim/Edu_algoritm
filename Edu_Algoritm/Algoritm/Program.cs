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

            QuickSort(ref quickList, 0, quickList.Length - 1);
            for (int i = 0; i < quickList.Length; i++)
            {
                Console.Write(quickList[i] + " ");
            }

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

        static int[] quickList = { 10, 1, 5, 8, 7, 6, 4, 3, 2, 9 };

        static void QuickSort(ref int[] sortList, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(ref quickList, start, end);
                QuickSort(ref quickList, start, pivot - 1);
                QuickSort(ref quickList, pivot + 1, end);
            }
        }

        static int Partition(ref int[] sortList, int start, int end)
        {
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (sortList[j] <= sortList[end])
                {
                    i++;
                    Swap(ref sortList, i, j);
                }
            }
            Swap(ref sortList, i + 1, end);
            return i + 1;
        }

        static void Swap(ref int[] sortList, int i, int j)
        {
            int temp = sortList[i];
            sortList[i] = sortList[j];
            sortList[j] = temp;
        }
    }
}
