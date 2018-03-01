namespace Dora.Weixin.MP.Entities.ReceiveMessage
{
    public class ReceiveMessageLocation : ReceiveMessageBase
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public override ReceiveMessageType MsgType
        {
            get { return ReceiveMessageType.Location; }
        }

        /// <summary>
        /// 地理位置维度
        /// </summary>
        public double Location_X { get; set; }

        /// <summary>
        /// 地理位置经度
        /// </summary>
        public double Location_Y { get; set; }

        /// <summary>
        /// 地图缩放大小
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// 地理位置信息
        /// </summary>
        public string Label { get; set; }

    }
}
