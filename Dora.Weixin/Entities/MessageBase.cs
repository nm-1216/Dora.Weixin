namespace Dora.Weixin.Entities
{
    using System;

    /// <summary>
    /// 消息的接口
    /// </summary>
    public interface IMessageBase
    {
        /// <summary>
        /// 接收人
        /// </summary>
        string ToUserName { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        string FromUserName { get; set; }

        /// <summary>
        /// 消息创建时间
        /// </summary>
        DateTime CreateTime { get; set; }
    }

    /// <summary>
    /// 消息类
    /// </summary>
    public abstract class MessageBase : IMessageBase
    {
        /// <summary>
        /// 接收人
        /// </summary>
        public virtual string ToUserName { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public virtual string FromUserName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime { get; set; }
    }

}
