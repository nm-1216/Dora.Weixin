namespace Dora.Weixin.MP.Entities.ReceiveMessage
{
    public interface IReceiveMessageBase : Weixin.Entities.IReceiveMessageBase
    {
        ReceiveMessageType MsgType { get; }
        string Encrypt { get; set; }
    }

    public class ReceiveMessageBase : Weixin.Entities.ReceiveMessageBase, IReceiveMessageBase
    {
        public virtual ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.Text; }
        }

        public virtual string Encrypt
        {
            get;
            set;
        }
    }
}
