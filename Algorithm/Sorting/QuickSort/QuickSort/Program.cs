using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = { 6, 4, 8, 2, 5, 13, 9 };

            Sorting(array, 0, array.Length - 1);

            Console.WriteLine("数组有序：");

            Print(array);

            Console.ReadKey();
        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static void Sorting(int[] array, int left, int right)
        {
            if (left < right)
            {
                //基准数
                int middle = array[(left + right) / 2];

                int i = left - 1;

                int j = right + 1;

                while (true)
                {
                    while (array[++i] < middle) ;
                    while (array[--j] > middle) ;

                    if (i >= j)
                    {
                        break;
                    }

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

                Sorting(array, left, i - 1);

                Sorting(array, j + 1, right);
            }
        }

        /// <summary>
        /// 输出数组元素
        /// </summary>
        /// <param name="array"></param>
        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
        }
    }
}
