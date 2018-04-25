//-----------------------------------------------------------------------
// <copyright file= "ChartFactory.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/25 星期三 10:38:35
// Modified by:
// Description: 图表工厂类
//-----------------------------------------------------------------------
using SimpleFactoryMode.Product;
using System;

namespace SimpleFactoryMode
{
    public class ChartFactory
    {
        /// <summary>
        /// 创建产品实例
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IChart GetChart(string type)
        {
            IChart chart = null;
            switch (type)
            {
                case "histogram":
                    chart = new HistogramChart();
                    Console.WriteLine("初始化设置柱状图");
                    break;
                case "pie":
                    chart = new PieChart();
                    Console.WriteLine("初始化设置饼状图");
                    break;
                case "line":
                    chart = new LineChart();
                    Console.WriteLine("初始化设置折线图");
                    break;
                default:
                    Console.WriteLine("当前类型不存在");
                    break;
            }
            return chart;
        }
    }
}
