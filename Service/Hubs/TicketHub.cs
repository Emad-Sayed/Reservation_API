using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Hubs
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Roles = "admin,employee")]
    public class TicketHub : Hub
    {
        public void GetConnectionId()
        {
            //Clients.All.SendAsync("saveConnectionId", Context.ConnectionId);
            Clients.Client(Context.ConnectionId).SendAsync("saveConnectionId", Context.ConnectionId);

        }
    }
}
