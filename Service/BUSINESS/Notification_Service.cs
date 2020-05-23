using _DB.Model.Ticket;
using _Service.INTERFACES.GENERAL;
using Microsoft.AspNetCore.SignalR;
using Service.Hubs;
using System;
using System.Collections.Generic;
using System.Text;
using static _Service.Vw_Model.Notification.NOTIFICATION_MODEL;

namespace _Service.BUSINESS
{
    public class Notification_Service : INOTIFICATION_SERVICE
    {
        private IHubContext<TicketHub> ticketContext;
        public Notification_Service(IHubContext<TicketHub> _ticketContext)
        {
            ticketContext = _ticketContext;
        }

        public async void Create_Ticket_Group(CREATE_NOTIFICATION_GROUP model)
        {
            await ticketContext.Groups.AddToGroupAsync(model.Connection_Id,model.Group_Name);
            //await ticketContext.Clients.All.SendAsync("receiveMessage", "Group Done");
        }
    
        public void Notifiy_New_Ticket(Ticket ticket)
        {
            ticketContext.Clients.Group(ticket.Branch_Departement_Id+"").SendAsync("receiveMessage",ticket.Id);
        }
    }
}
