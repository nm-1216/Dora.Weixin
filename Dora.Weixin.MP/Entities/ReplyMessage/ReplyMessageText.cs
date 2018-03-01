namespace Dora.Weixin.MP.Entities
{
    public class ReplyMessageText: ReplyMessageBase, IReplyMessageBase
    {
        public new virtual ReplyMsgType MsgType
        {
            get { return ReplyMsgType.Text; }
        }

        public string Content { get; set; }
    }
}
