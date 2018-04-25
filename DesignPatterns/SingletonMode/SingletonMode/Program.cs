using System;

namespace SingletonMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 单例类（未考虑多线程）
        /// </summary>
        public class Singleton
        {
            /// <summary>
            /// 静态私有变量，存储当前类的实例
            /// </summary>
            private static Singleton _instance { get; set; }

            /// <summary>
            /// 静态构造函数，防止外界创建实例
            /// </summary>
            private Singleton() { }

            /// <summary>
            /// 公有访问，提供全局访问点，确保外界访问到的是同一实例
            /// </summary>
            /// <returns></returns>
            public static Singleton GetSingleton()
            {
                //判断是否存在当前类实例，不存在则创建，存在则直接返回
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        /// <summary>
        /// 单例类（考虑多线程并发）
        /// </summary>
        public class SingletonMultithreading
        {
            /// <summary>
            /// 静态私有变量，存储当前类的实例
            /// </summary>
            private static SingletonMultithreading _instance { get; set; }

            /// <summary>
            /// 定义标识，确保线程同步
            /// </summary>
            public static readonly object locker = new object();

            /// <summary>
            /// 静态构造函数，防止外界创建实例
            /// </summary>
            private SingletonMultithreading() { }

            /// <summary>
            /// 公有访问，提供全局访问点，确保外界访问到的是同一实例
            /// </summary>
            /// <returns></returns>
            public static SingletonMultithreading GetSingleton()
            {
                #region 为什么判断两次实例是否创建
                //最外层判断：线程访问时判断实例是否创建，实例已创建就不再创建，获取实例
                //加锁后再判断实例是否创建：实例未创建，A、B同时访问该类，A加锁，B等待
                //                        A创建实例完成，解除锁定，此时B获得对_instance字段的访问权，若不对实例是否已经创建进行判断，此时B还会创建一个实例，违反单例原则  
                #endregion

                //1、判断是否存在当前类实例，不存在则进行进一步的判断，存在则直接返回实例
                if (_instance == null)
                {
                    //2、对标识进行加锁，挂起其它线程的访问
                    lock (locker)
                    {
                        //3、判断是否存在实例，存在则直接返回
                        if (_instance == null)
                        {
                            _instance = new SingletonMultithreading();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
