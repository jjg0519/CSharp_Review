using FactoryMode.Factory;
using System;

namespace FactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //创建工厂
            FoodFactory tomatoFactory = new TomatoFactory();
            FoodFactory potatoFactory = new PotatoFactory();

            //做菜
            Food tomato = tomatoFactory.CreateFood();
            tomato.Print();

            Food potato = potatoFactory.CreateFood();
            potato.Print();

            //新增产品时，创建新的产品类和产品工厂类就可以了

            Console.ReadKey();
        }
    }
}
