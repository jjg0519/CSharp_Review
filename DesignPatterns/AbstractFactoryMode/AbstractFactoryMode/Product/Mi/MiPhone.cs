//-----------------------------------------------------------------------
// <copyright file= "MiPhone.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:22:11
// Modified by:
// Description: Xiaomi 具体Phone产品类
//-----------------------------------------------------------------------
using System;

namespace AbstractFactoryMode.Product.Mi
{
    public class MiPhone : PhoneProduct
    {
        /// <summary>
        /// 输出产品信息
        /// </summary>
        public override void Print() => Console.WriteLine("我是MiPhone 2050");
    }
}
