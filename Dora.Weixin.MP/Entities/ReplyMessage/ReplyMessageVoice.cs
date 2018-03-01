namespace Dora.Weixin.MP.Entities
{
    public class ReplyMessageVoice : ReplyMessageBase, IReplyMessageBase
    {
        public new virtual ReplyMsgType MsgType
        {
            get { return ReplyMsgType.Voice; }
        }

        public Voice Voice { get; set; }
    }
}
