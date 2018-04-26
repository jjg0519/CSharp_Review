//-----------------------------------------------------------------------
// <copyright file= "Iphone.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:18:09
// Modified by:
// Description: Apple 具体Phone产品类
//-----------------------------------------------------------------------
using System;

namespace AbstractFactoryMode.Product.Apple
{
    public class Iphone : PhoneProduct
    {
        /// <summary>
        /// 输出产品信息
        /// </summary>
        public override void Print() => Console.WriteLine("我是 Iphone 2050");
    }
}
