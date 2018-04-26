//-----------------------------------------------------------------------
// <copyright file= "Computer.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 14:09:59
// Modified by:
// Description: 电脑类
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternMode
{
    public class Computer
    {
        /// <summary>
        /// 电脑组件集合
        /// </summary>
        private List<string> parts = new List<string>();

        /// <summary>
        /// 将单个组件添加到电脑组件集合中
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("开始组装电脑~~~");
            foreach (var item in parts)
            {
                Console.WriteLine($"{item}已安装完毕");
            }
            Console.WriteLine("电脑组装完成~~~");
        }
    }
}
