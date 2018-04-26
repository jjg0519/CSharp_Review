//-----------------------------------------------------------------------
// <copyright file= "SecondBuilder.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018/4/26 星期四 14:35:06
// Modified by:
// Description: 创建者
//-----------------------------------------------------------------------

namespace BuilderPatternMode
{
    public class SecondBuilder : Builder
    {
        /// <summary>
        /// 需要创建完成的整个对象
        /// </summary>
        Computer computer = new Computer();

        /// <summary>
        /// 构建操作1
        /// </summary>
        public override void BuildCPU() => computer.Add("CPU By SecondBuilder");

        /// <summary>
        /// 构建操作2
        /// </summary>
        public override void BuildMotherboard() => computer.Add("Motherboard By SecondBuilder");

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
