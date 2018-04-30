using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = { 5, 8, 2, 1, 4, 6 };

            Sorting(array);

            Console.WriteLine("排序后的数组序列为：");
            Print(array);

            Console.ReadKey();
        }

        static void Sorting(int[] array)
        {
            //每趟查找
            for (int i = 0; i < array.Length - 1; i++)
            {
                //设定最大值所在的索引号
                int max = i;

                //循环剩下的元素，找出最大值进行比较
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[max] < array[j])
                    {
                        //最大值所在的索引
                        max = j;
                    }
                }

                //将最大值与当前i进行交换
                int temp = array[max];
                array[max] = array[i];
                array[i] = temp;

                Console.WriteLine($"第{i + 1}趟排序后的数组数组顺序为：");
                Print(array);
            }
        }

        /// <summary>
        /// 打印数组元素
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
