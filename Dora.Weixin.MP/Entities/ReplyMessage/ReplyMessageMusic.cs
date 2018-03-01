namespace Dora.Weixin.MP.Entities
{
    public class ReplyMessageMusic : ReplyMessageBase, IReplyMessageBase
    {
        public new virtual ReplyMsgType MsgType
        {
            get { return ReplyMsgType.Music; }
        }

        public Music Music { get; set; }
    }
}
