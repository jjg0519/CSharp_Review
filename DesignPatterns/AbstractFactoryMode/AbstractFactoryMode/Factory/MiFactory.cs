//-----------------------------------------------------------------------
// <copyright file= "MiFactory.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:31:52
// Modified by:
// Description: Xiaomi 产品工厂
//-----------------------------------------------------------------------
using AbstractFactoryMode.Product;
using AbstractFactoryMode.Product.Mi;

namespace AbstractFactoryMode.Factory
{
    public class MiFactory : ProductFactory
    {
        /// <summary>
        /// 创建MiPad产品
        /// </summary>
        /// <returns></returns>
        public override PadProduct CreatePad()
        {
            return new MiPad();
        }

        /// <summary>
        /// 创建MiPhone产品
        /// </summary>
        /// <returns></returns>
        public override PhoneProduct CreatePhone()
        {
            return new MiPhone();
        }
    }
}
