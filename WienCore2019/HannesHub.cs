using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WienCore2019
{
    public class HannesHub:Hub
    {
   public async Task HannesHallo(string msg)
        {
            await Clients.All.SendAsync("hannesruftan", DateTime.Now.ToShortTimeString() + ":" + msg);
        }
    }
}
