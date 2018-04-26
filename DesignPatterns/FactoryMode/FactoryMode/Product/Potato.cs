//-----------------------------------------------------------------------
// <copyright file= "Potato.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 9:31:43
// Modified by:
// Description: 土豆产品类
//-----------------------------------------------------------------------
using System;

namespace FactoryMode.Product
{
    public class Potato : Food
    {
        /// <summary>
        /// 输出菜品信息
        /// </summary>
        public override void Print() => Console.WriteLine("用户点了香辣土豆丝");
    }
}
