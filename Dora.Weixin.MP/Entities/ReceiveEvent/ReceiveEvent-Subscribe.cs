﻿namespace Dora.Weixin.MP.Entities.ReceiveEvent
{
    public class ReceiveEvent_Subscribe : ReceiveEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.Subscribe; }
        }

        /// <summary>
        /// 事件KEY值，qrscene_为前缀，后面为二维码的参数值（如果不是扫描场景二维码，此参数为空）
        /// </summary>
        public string EventKey { get; set; }

        /// <summary>
        /// 二维码的ticket，可用来换取二维码图片（如果不是扫描场景二维码，此参数为空）
        /// </summary>
        public string Ticket { get; set; }
    }
}
