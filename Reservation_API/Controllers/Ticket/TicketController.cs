using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Service.INTERFACES.TICKET;
using _Service.Vw_Model.GENERAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Reservation_API.Helpers;
using Service.Hubs;
using Service.Vw_Model.TEST;
using static _Service.Vw_Model.TICKET.TICKET_MODEL;

namespace Reservation_API.Controllers.Ticket
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private IHubContext<TicketHub> _ticketContext;
        private ITICKET_SERVICE service;
        public TicketController(IHubContext<TicketHub> ticketContext,ITICKET_SERVICE service_)
        {
            _ticketContext = ticketContext;
            service = service_;
        }
        [HttpPost]
        public ActionResult SendMessage([FromBody]Message message)
        {
            _ticketContext.Clients.All.SendAsync("receiveMessage", message.body);
            return Ok();
        }
        [HttpGet("GET_PAGINATION")]
        public ActionResult GET_TICKETS([FromBody]PAGINATION_MODEL Paging)
        {
            var Branch_Dept = int.Parse(User.GetClaimType("Branch_Departement"));
            var result = service.GET_TICKETS(Paging, Branch_Dept);
            if (result.Status == false)
                return BadRequest();
            return Ok(result);
        }
        [HttpPost("ADD_TICKET")]
        public ActionResult ADD_TICKET([FromBody]ADD_TICKET_MODEL Ticket)
        {
            Ticket.CLIENT_ID = User.GetClaimType("Id");
            var result = service.ADD_TICKET(Ticket);
            if (result.Status == false)
                return BadRequest();
            return Ok(result);
        }
    }
}