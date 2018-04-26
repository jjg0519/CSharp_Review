
//-----------------------------------------------------------------------
// <copyright file= "AppleFactory.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:30:06
// Modified by:
// Description: Apple 产品工厂
//-----------------------------------------------------------------------
using AbstractFactoryMode.Product;
using AbstractFactoryMode.Product.Apple;

namespace AbstractFactoryMode.Factory
{
    public class AppleFactory : ProductFactory
    {
        /// <summary>
        /// 创建Ipad产品
        /// </summary>
        /// <returns></returns>
        public override PadProduct CreatePad()
        {
            return new Ipad();
        }

        /// <summary>
        /// 创建Iphone产品
        /// </summary>
        /// <returns></returns>
        public override PhoneProduct CreatePhone()
        {
            return new Iphone();
        }
    }
}
