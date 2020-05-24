using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Service.HUBS
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TicketServingHub : Hub
    {
        public void CreateTracingGroup(string GroupName)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, GroupName);
            //Clients.Group(GroupName).SendAsync("receiveMessage", "Group Created");
        }
    }
}
