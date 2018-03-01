namespace Dora.Weixin.MP.Entities.ReceiveMessage
{
    public class ReceiveMessageShortVideo : ReceiveMessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public override ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.ShortVideo; }
        }

        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string ThumbMediaId { get; set; }

        /// <summary>
        /// 图片消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }

    }
}
