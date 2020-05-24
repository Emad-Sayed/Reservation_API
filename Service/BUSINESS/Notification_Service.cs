using _DB.Model.Ticket;
using _Service.HUBS;
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
        private IHubContext<TicketHub> ticketContext; // Employees Update List With new ticket
        private IHubContext<TicketServingHub> servingContext; // Users Ticket Serving Tracing 
        public Notification_Service(IHubContext<TicketHub> _ticketContext, IHubContext<TicketServingHub> _servingContext)
        {
            ticketContext = _ticketContext;
            servingContext = _servingContext;
        }
        public void Notifiy_New_Ticket(Ticket ticket)
        {
            ticketContext.Clients.Group(ticket.Branch_Departement_Id+"").SendAsync("newTicketAdded",ticket);
        }
        public void Notifiy_New_Serving(Ticket ticket)
        {
            servingContext.Clients.Group(ticket.Branch_Departement_Id + "").SendAsync("newTicketServing", ticket.Ticket_Number);
        }
    }
}
