//-----------------------------------------------------------------------
// <copyright file= "FoodFactory.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 9:22:26
// Modified by:
// Description: 产品抽象工厂类
//-----------------------------------------------------------------------

namespace FactoryMode
{
    public abstract class FoodFactory
    {
        /// <summary>
        /// 创建菜品
        /// </summary>
        /// <returns></returns>
        public abstract Food CreateFood();
    }
}
