﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc

    文件名：WebSocketMessageHandler.cs
    文件功能描述：WebSocketMessageHandler基类


    创建标识：Senparc - 20170127

----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.WebSockets;

namespace Senparc.WebSocket
{
    /// <summary>
    /// WebSocket 处理程序
    /// </summary>
    public abstract class WebSocketMessageHandler
    {
        /// <summary>
        /// 连接时触发事件
        /// </summary>
        /// <param name="webSocketHandler"></param>
        /// <returns></returns>
        public virtual Task OnConnecting(WebSocketHelper webSocketHandler)
        {
            return null;
        }

        /// <summary>
        /// 断开连接时触发事件
        /// </summary>
        /// <param name="webSocketHandler"></param>
        /// <returns></returns>
        public virtual Task OnDisConnected(WebSocketHelper webSocketHandler)
        {
            return null;
        }

        /// <summary>
        /// 收到消息时触发事件
        /// </summary>
        /// <param name="webSocketHandler"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public abstract Task OnMessageReceiced(WebSocketHelper webSocketHandler, string message);
    }
}
