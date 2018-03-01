namespace Dora.Weixin.MP.Entities.ReceiveEvent
{
    public class ReceiveEvent_Scan : ReceiveEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.Unsubscribe; }
        }
    }
}
