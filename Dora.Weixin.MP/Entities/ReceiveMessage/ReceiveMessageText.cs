namespace Dora.Weixin.MP.Entities.ReceiveMessage
{
    public class ReceiveMessageText: ReceiveMessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public override ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.Text; }
        }

        /// <summary>
        /// 文本消息内容
        /// </summary>
        public string Content { get; set; }
    }
}
