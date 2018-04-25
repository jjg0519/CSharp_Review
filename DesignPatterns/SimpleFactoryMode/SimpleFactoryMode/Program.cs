using System;

namespace SimpleFactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IChart chart = ChartFactory.GetChart("pie");
            chart.Display();
            Console.ReadKey();
        }
    }
}
