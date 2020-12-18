﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaSignalR.Hubs
{
    public class PositionHub : Hub
    {
        public async Task SendPosition(int left, int top)
        {
            await Clients.Others.SendAsync("ReceivePosition", left, top);
        }
    }
}
