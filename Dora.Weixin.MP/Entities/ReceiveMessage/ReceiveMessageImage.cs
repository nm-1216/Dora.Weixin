namespace Dora.Weixin.MP.Entities.ReceiveMessage
{
    public class ReceiveMessageImage : ReceiveMessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public override ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.Image; }
        }

        /// <summary>
        /// 图片链接（由系统生成）
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }
    }
}
