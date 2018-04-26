//-----------------------------------------------------------------------
// <copyright file= "ProductFactory.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:27:53
// Modified by:
// Description: 工厂父类
//-----------------------------------------------------------------------
using AbstractFactoryMode.Product;

namespace AbstractFactoryMode.Factory
{
    public abstract class ProductFactory
    {
        /// <summary>
        /// 创建Pad产品
        /// </summary>
        /// <returns></returns>
        public abstract PadProduct CreatePad();

        /// <summary>
        /// 创建Phone产品
        /// </summary>
        /// <returns></returns>
        public abstract PhoneProduct CreatePhone();
    }
}
