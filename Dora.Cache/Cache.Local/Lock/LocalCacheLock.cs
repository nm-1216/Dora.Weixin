namespace Dora.Cache
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// 本地锁
    /// </summary>
    public class LocalCacheLock : BaseCacheLock
    {
        private IBaseCacheStrategy _localStrategy;
        public LocalCacheLock(IBaseCacheStrategy strategy, string resourceName, string key, int? retryCount = null, TimeSpan? retryDelay = null)
        : base(strategy, resourceName, key, retryCount ?? 0, retryDelay ?? TimeSpan.FromMilliseconds(10))
        {
            _localStrategy = strategy;
            LockNow();
        }

        /// <summary>
        /// 锁存放容器
        /// </summary>
        private static Dictionary<string, object> LockPool = new Dictionary<string, object>();

        /// <summary>
        /// 随机数
        /// </summary>
        private static Random _rnd = new Random();

        /// <summary>
        /// 读取LockPool时的锁
        /// </summary>
        private static object lookPoolLock = new object();

        public override bool Lock(string resourceName)
        {
            return Lock(resourceName, 99999, new TimeSpan(0, 0, 0, 0, 10));
        }

        public override bool Lock(string resourceName, int retryCount, TimeSpan retryDelay)
        {

            int currentRetry = 0;
            int maxRetryDelay = (int)retryDelay.TotalMilliseconds;
            while (currentRetry++ < retryCount)
            {
                #region 尝试获得锁

                var getLock = false;
                try
                {
                    lock (lookPoolLock)
                    {
                        if (LockPool.ContainsKey(resourceName))
                        {
                            getLock = false;
                        }
                        else
                        {
                            LockPool.Add(resourceName, new object());
                            getLock = true;
                        }
                    }
                }
                catch
                {
                    getLock = false;
                }

                #endregion

                if (getLock)
                {
                    return true;
                }
                Thread.Sleep(_rnd.Next(maxRetryDelay));
            }
            return false;
        }

        public override void UnLock(string resourceName)
        {
            lock (lookPoolLock)
            {
                LockPool.Remove(resourceName);
            }
        }
    }
}
