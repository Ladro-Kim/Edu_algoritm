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

            WriteResult(InsertSort(list));

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
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine(" ");
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

                //if (list[i] > list[i + 1])
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        if (list[j] > list[i+1])
                //        {
                //            list[j + 1] = list[j];
                //            list[j] = list[i + 1];
                //        }
                //    }
                //}
            }
            Console.Write("Insert sort Result : ");
            return list;
        }


    }
}
