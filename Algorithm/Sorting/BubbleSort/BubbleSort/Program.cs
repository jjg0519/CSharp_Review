using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = { 6, 4, 8, 2, 5, 13, 9 };

            Sorting(array);

            Console.WriteLine("数组有序：");

            Print(array);

            Console.ReadKey();
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="array"></param>
        static void Sorting(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }

                Console.WriteLine($"第{i + 1}次外循环排序后的数组为：");
                Print(array);
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
