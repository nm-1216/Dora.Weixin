namespace Dora.Weixin.MP.Entities
{
    using System.Collections.Generic;

    public class ReplyMessageNews: ReplyMessageBase, IReplyMessageBase
    {
        public new virtual ReplyMsgType MsgType
        {
            get { return ReplyMsgType.News; }
        }

        public int ArticleCount
        {
            get
            {
                return Articles == null ? 0 : Articles.Count;
            }
        }

        public List<Article> Articles { get; set; }
    }
}
