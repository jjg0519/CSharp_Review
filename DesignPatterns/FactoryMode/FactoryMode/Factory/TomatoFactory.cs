//-----------------------------------------------------------------------
// <copyright file= "TomatoFactory.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 9:34:32
// Modified by:
// Description: 番茄工厂类
//-----------------------------------------------------------------------
using FactoryMode.Product;

namespace FactoryMode.Factory
{
    public class TomatoFactory : FoodFactory
    {
        /// <summary>
        /// 创建番茄
        /// </summary>
        /// <returns></returns>
        public override Food CreateFood()
        {
            return new Tomato();
        }
    }
}
