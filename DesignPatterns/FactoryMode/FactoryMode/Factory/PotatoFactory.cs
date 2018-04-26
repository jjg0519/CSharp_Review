//-----------------------------------------------------------------------
// <copyright file= "PotatoFactory.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 9:36:07
// Modified by:
// Description: 土豆工厂类
//-----------------------------------------------------------------------
using FactoryMode.Product;

namespace FactoryMode.Factory
{
    public class PotatoFactory : FoodFactory
    {
        /// <summary>
        /// 创建土豆
        /// </summary>
        /// <returns></returns>
        public override Food CreateFood()
        {
            return new Potato();
        }
    }
}
