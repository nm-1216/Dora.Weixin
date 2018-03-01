namespace Dora.Weixin.MP.Entities
{
    public class ReplyMessageVideo : ReplyMessageBase, IReplyMessageBase
    {
        public new virtual ReplyMsgType MsgType
        {
            get { return ReplyMsgType.Video; }
        }

        public Video Video { get; set; }
    }
}
