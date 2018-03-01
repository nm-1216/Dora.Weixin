namespace Dora.Weixin.MP.Entities.ReceiveEvent
{
    public class ReceiveEvent_Click : ReceiveEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.Click; }
        }

        /// <summary>
        /// 事件KEY值，与自定义菜单接口中KEY值对应
        /// </summary>
        public string EventKey { get; set; }
    }
}
