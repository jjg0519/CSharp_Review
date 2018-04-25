//-----------------------------------------------------------------------
// <copyright file= "HistogramChart.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/25 星期三 10:36:49
// Modified by:
// Description: 柱状图产品类
//-----------------------------------------------------------------------
using System;

namespace SimpleFactoryMode.Product
{
    public class HistogramChart : IChart
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图产品");
        }

        public void Display()
        {
            Console.WriteLine("显示柱状图产品");
        }
    }
}
