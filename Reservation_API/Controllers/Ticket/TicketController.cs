using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _DB.Vw_Model.TEST;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Service.Hubs;

namespace Reservation_API.Controllers.Ticket
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private IHubContext<TicketHub> _ticketContext;

        public TicketController(IHubContext<TicketHub> ticketContext)
        {
            _ticketContext = ticketContext;
        }
        [HttpPost]
        public ActionResult SendMessage([FromBody]Message message)
        {
            _ticketContext.Clients.All.SendAsync("receiveMessage", message.body);
            return Ok();
        }
    }
}