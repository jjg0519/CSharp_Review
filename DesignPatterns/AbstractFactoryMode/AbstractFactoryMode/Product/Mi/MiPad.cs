//-----------------------------------------------------------------------
// <copyright file= "MiPad.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:20:57
// Modified by:
// Description: Xiaomi 具体Pad产品类
//-----------------------------------------------------------------------
using System;

namespace AbstractFactoryMode.Product.Mi
{
    public class MiPad : PadProduct
    {
        /// <summary>
        /// 输出产品信息
        /// </summary>
        public override void Print() => Console.WriteLine("我是MiPad 2050");
    }
}
