namespace Dora.Weixin.MP.Entities
{
    public interface IReplyMessageBase : Weixin.Entities.IReplyMessageBase
    {
        ReplyMsgType MsgType { get; }
    }

    public abstract class ReplyMessageBase : Weixin.Entities.ReplyMessageBase, IReplyMessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public virtual ReplyMsgType MsgType
        {
            get { return ReplyMsgType.Text; }
        }
    }
}
