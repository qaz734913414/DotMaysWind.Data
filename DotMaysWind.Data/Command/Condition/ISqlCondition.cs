﻿using System;

namespace DotMaysWind.Data.Command.Condition
{
    /// <summary>
    /// Sql条件语句接口
    /// </summary>
    public interface ISqlCondition
    {
        /// <summary>
        /// 获取语句类型
        /// </summary>
        SqlConditionType ConditionType { get; }

        /// <summary>
        /// 获取所在Sql语句
        /// </summary>
        ISqlCommand SqlCommand { get; }

        /// <summary>
        /// 获取条件语句参数集合
        /// </summary>
        /// <returns>条件语句参数集合</returns>
        DataParameter[] GetAllParameters();

        /// <summary>
        /// 输出条件语句内容
        /// </summary>
        /// <returns>条件语句内容</returns>
        String GetClauseText();
    }
}