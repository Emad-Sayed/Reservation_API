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
        public void CreateNotificationGroup(string GroupName)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, GroupName);
            Clients.Group(GroupName).SendAsync("receiveMessage", "Group Created");
        }
    }
}
