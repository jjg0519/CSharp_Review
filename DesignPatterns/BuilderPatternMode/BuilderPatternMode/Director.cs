//-----------------------------------------------------------------------
// <copyright file= "Director.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 14:04:06
// Modified by:
// Description: 指挥者
//-----------------------------------------------------------------------

namespace BuilderPatternMode
{
    /// <summary>
    /// 指挥整个创建复杂对象的过程，分配创建工作
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 组装电脑
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildCPU();
            builder.BuildMotherboard();
        }
    }
}
