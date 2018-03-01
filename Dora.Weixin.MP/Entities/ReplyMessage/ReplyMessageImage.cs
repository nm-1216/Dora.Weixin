namespace Dora.Weixin.MP.Entities
{
    public class ReplyMessageImage : ReplyMessageBase, IReplyMessageBase
    {
        public new virtual ReplyMsgType MsgType
        {
            get { return ReplyMsgType.Image; }
        }

        public Image Image { get; set; }
    }
}
