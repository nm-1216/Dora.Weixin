namespace Dora.Weixin.Entities
{
    public interface IReceiveMessageBase : IMessageBase
    {
        long MsgId { get; set; }
    }

    public class ReceiveMessageBase : MessageBase, IReceiveMessageBase
    {
        public virtual long MsgId
        {
            get;
            set;
        }
    }
}
