using System;

namespace InsertSort
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
        /// 插入排序
        /// </summary>
        /// <param name="array"></param>
        static void Sorting(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                //保存当前位置的元素，此时[0,...,i-1]处的元素都已有序
                int temp = array[i];
                //前j位元素都已有序
                int j = i - 1;

                while (j >= 0 && temp < array[j])
                {
                    //将当前位置的元素与有序序列中的每一个元素进行比较
                    array[j + 1] = array[j];
                    j--;
                }

                //有序序列的所有元素都小于当前位置元素
                array[j + 1] = temp;

                Console.WriteLine($"第{i + 1}次排序后的数组序列为：");
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
