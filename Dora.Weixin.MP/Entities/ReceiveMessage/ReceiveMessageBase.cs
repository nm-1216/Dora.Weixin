using Dora.Weixin.Entities;

namespace Dora.Weixin.MP.Entities.ReceiveMessage
{
    public abstract class ReceiveMessageBase : MessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public virtual ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.Text; }
        }

        /// <summary>
        /// 好像没用
        /// </summary>
        public string Encrypt { get; set; }

        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        public long MsgId { get; set; }
    }
}
