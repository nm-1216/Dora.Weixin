namespace Dora.Weixin.MP.Entities
{
    public interface IReplyMessageBase : Weixin.Entities.IReplyMessageBase
    {
        ReceiveMessageType MsgType { get; }
    }

    public abstract class ReplyMessageBase : Weixin.Entities.ReplyMessageBase, IReplyMessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public virtual ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.Text; }
        }
    }
}
