using _Service.INTERFACES.GENERAL;
using Microsoft.AspNetCore.SignalR;
using Service.Hubs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Service.BUSINESS
{
    public class Notification_Service : INOTIFICATION_SERVICE
    {
        private IHubContext<TicketHub> ticketContext;
        public Notification_Service(IHubContext<TicketHub> _ticketContext)
        {
            ticketContext = _ticketContext;
        }

        public void Create_Ticket_Group()
        {
            throw new NotImplementedException();
        }

        public void Notifiy_New_Ticket()
        {
            ticketContext.Clients.All.SendAsync("receiveMessage","New Ticket");
        }
    }
}
