//-----------------------------------------------------------------------
// <copyright file= "Ipad.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:16:57
// Modified by:
// Description: Apple 具体Pad产品类
//-----------------------------------------------------------------------
using System;

namespace AbstractFactoryMode.Product.Apple
{
    public class Ipad : PadProduct
    {
        /// <summary>
        /// 输出产品信息
        /// </summary>
        public override void Print() => Console.WriteLine("我是Ipad 2050");
    }
}
