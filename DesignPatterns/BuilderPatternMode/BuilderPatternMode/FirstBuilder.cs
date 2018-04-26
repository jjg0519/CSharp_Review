//-----------------------------------------------------------------------
// <copyright file= "FirstBuilder.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 14:27:15
// Modified by:
// Description: 创建者
//-----------------------------------------------------------------------

namespace BuilderPatternMode
{
    /// <summary>
    /// 具体创建者1，用来完成指挥者分配的任务
    /// </summary>
    public class FirstBuilder : Builder
    {
        /// <summary>
        /// 需要创建完成的整个对象
        /// </summary>
        Computer computer = new Computer();

        /// <summary>
        /// 构建操作1
        /// </summary>
        public override void BuildCPU() => computer.Add("CPU By FirstBuilder");

        /// <summary>
        /// 构建操作2
        /// </summary>
        public override void BuildMotherboard() => computer.Add("Motherboard By FirstBuilder");

        /// <summary>
        /// 获取组装好的对象
        /// </summary>
        /// <returns></returns>
        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
