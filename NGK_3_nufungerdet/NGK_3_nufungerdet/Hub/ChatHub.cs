using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace NGK_3_nufungerdet.hub
{
    public class MeasurementHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("SendMeasurement");
        }
    }
}
