namespace Dora.Weixin.MP.Entities.ReceiveEvent
{
    using Dora.Weixin.Entities;

    public abstract class ReceiveEventBase : MessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public virtual ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.Event; }
        }

        /// <summary>
        /// 事件类型
        /// </summary>
        public virtual Event Event
        {
            get { return Event.Subscribe; }
        }
    }
}
