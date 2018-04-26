//-----------------------------------------------------------------------
// <copyright file= "Builder.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 14:04:56
// Modified by:
// Description: 建造者
//-----------------------------------------------------------------------

namespace BuilderPatternMode
{
    /// <summary>
    /// 抽象构造者，可定义成接口，包含创建各个组件的方法
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 构造主板
        /// </summary>
        public abstract void BuildMotherboard();

        /// <summary>
        /// 构造CPU
        /// </summary>
        public abstract void BuildCPU();

        //其它构建组件方法...

        /// <summary>
        /// 获取组装好的电脑对象
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();
    }
}
