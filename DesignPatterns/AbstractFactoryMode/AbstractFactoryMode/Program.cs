using AbstractFactoryMode.Factory;
using AbstractFactoryMode.Product;
using System;

namespace AbstractFactoryMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //小米工厂生产
            ProductFactory xiaomi = new MiFactory();
            PadProduct mipad = xiaomi.CreatePad();
            mipad.Print();
            PhoneProduct miphone = xiaomi.CreatePhone();
            miphone.Print();

            //苹果工厂生产
            ProductFactory apple = new AppleFactory();
            PadProduct ipad = apple.CreatePad();
            ipad.Print();
            PhoneProduct iphone = apple.CreatePhone();
            iphone.Print();

            //当有新的公司时（Nexus）
            //创建 NexusFactory：继承工厂基类，实现创建pad产品、phone产品方法
            //创建 NexusPad：继承Pad产品基类，实现Pad产品信息
            //创建 NexusPhone：继承Phone产品基类，实现Phone产品信息

            Console.ReadKey();
        }
    }
}
