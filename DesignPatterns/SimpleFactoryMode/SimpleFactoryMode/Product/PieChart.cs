//-----------------------------------------------------------------------
// <copyright file= "PieChart.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/25 星期三 10:37:50
// Modified by:
// Description: 饼图产品类
//-----------------------------------------------------------------------
using System;

namespace SimpleFactoryMode.Product
{
    public class PieChart : IChart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼图");
        }

        public void Display()
        {
            Console.WriteLine("显示饼图");
        }
    }
}
