namespace Dora.Weixin.Entities
{
    using System;

    public abstract class MessageBase
    {
        /// <summary>
        /// 接收人
        /// </summary>
        public string ToUserName { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public string FromUserName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }

}
