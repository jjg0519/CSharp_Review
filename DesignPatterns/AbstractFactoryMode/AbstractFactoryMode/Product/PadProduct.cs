//-----------------------------------------------------------------------
// <copyright file= "PadProduct.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 11:14:35
// Modified by:
// Description: Pad产品抽象类
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMode.Product
{
    public abstract class PadProduct
    {
        /// <summary>
        /// 输出产品信息
        /// </summary>
        public abstract void Print();
    }
}
