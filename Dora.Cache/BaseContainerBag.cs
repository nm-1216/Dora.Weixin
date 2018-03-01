namespace Dora.Cache
{
    using System;

    /// <summary>
    /// BaseContainer容器中的Value类型
    /// </summary>
    public interface IBaseContainerBag
    {
        /// <summary>
        /// 用于标记，方便后台管理
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 缓存键
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// 当前对象被缓存的时间
        /// </summary>
        DateTime CacheTime { get; set; }
    }
}
