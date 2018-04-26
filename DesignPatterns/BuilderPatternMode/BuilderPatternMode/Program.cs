using System;

namespace BuilderPatternMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //创建指挥者和建造者
            Director director = new Director();
            Builder first = new FirstBuilder();
            Builder second = new SecondBuilder();

            //指挥者分配任务给构建者完成第一个对象
            director.Construct(first);
            //获取构建好的对象
            Computer computer1 = first.GetComputer();
            computer1.Show();

            //指挥者分配任务给构建者完成第二个对象
            director.Construct(second);
            //获取构建好的对象
            Computer computer2 = second.GetComputer();
            computer2.Show();

            Console.ReadKey();
        }
    }
}
