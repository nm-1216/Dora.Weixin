namespace Dora.Cache
{
    using System;

    public class CacheStrategyFactory
    {
        internal static Func<IContainerCacheStrategy> ContainerCacheStrateFunc;

        internal static Func<IObjectCacheStrategy> ObjectCacheStrateFunc;

        public static void RegisterObjectCacheStrategy(Func<IObjectCacheStrategy> func)
        {
            ObjectCacheStrateFunc = func;
        }

        public static IObjectCacheStrategy GetObjectCacheStrategyInstance()
        {
            if (ObjectCacheStrateFunc == null)
            {
                return LocalObjectCacheStrategy.Instance;
            }
            else
            {
                var instance = ObjectCacheStrateFunc();
                return instance;
            }
        }
    }
}
