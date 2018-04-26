//-----------------------------------------------------------------------
// <copyright file= "Tomato.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 9:24:01
// Modified by:
// Description: 番茄产品类
//-----------------------------------------------------------------------
using System;

namespace FactoryMode.Product
{
    public class Tomato : Food
    {
        /// <summary>
        /// 输出菜品信息
        /// </summary>
        public override void Print() => Console.WriteLine("用户点了番茄炒鸡蛋");
    }
}
