//-----------------------------------------------------------------------
// <copyright file= "PhoneProduct.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:15:11
// Modified by:
// Description: Phone产品抽象类
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMode.Product
{
    public abstract class PhoneProduct
    {
        /// <summary>
        /// 输出产品信息
        /// </summary>
        public abstract void Print();
    }
}
