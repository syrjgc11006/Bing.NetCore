﻿namespace Bing.Datas.Sql.Builders
{
    /// <summary>
    /// Sql方言
    /// </summary>
    public interface IDialect
    {
        /// <summary>
        /// 起始转义标识符
        /// </summary>
        char OpeningIdentifier { get; }

        /// <summary>
        /// 结束转义标识符
        /// </summary>
        char ClosingIdentifier { get; }

        /// <summary>
        /// 批量操作分隔符
        /// </summary>
        char BatchSeperator { get; }

        /// <summary>
        /// 安全名称
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        string SafeName(string name);

        /// <summary>
        /// 获取参数前缀
        /// </summary>
        /// <returns></returns>
        string GetPrefix();
    }
}
