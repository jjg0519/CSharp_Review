//-----------------------------------------------------------------------
// <copyright file= "LineChart.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/25 星期三 10:37:24
// Modified by:
// Description: 折线图产品类
//-----------------------------------------------------------------------
using System;

namespace SimpleFactoryMode.Product
{
    public class LineChart : IChart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图");
        }

        public void Display()
        {
            Console.WriteLine("显示折线图");
        }
    }
}
