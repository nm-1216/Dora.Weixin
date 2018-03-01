namespace Dora.Weixin.Entities
{
    public interface IReplyMessageBase : IMessageBase
    {
    }

    public abstract class ReplyMessageBase : MessageBase, IReplyMessageBase
    {
    }
}
