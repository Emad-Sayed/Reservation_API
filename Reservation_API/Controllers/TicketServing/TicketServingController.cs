using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Service.INTERFACES.TICKET;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation_API.Helpers;
using static _Service.Vw_Model.TICKET.TICKET_MODEL;

namespace Reservation_API.Controllers.TicketServing
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketServingController : ControllerBase
    {
        private ITICKET_SERVING_SERVICE service;
        public TicketServingController(ITICKET_SERVING_SERVICE service_)
        {
            service = service_;
        }
        [HttpGet("GET_CURRENT_SERVING")]
        public ActionResult GET_CURRENT_SERVING()
        {
            var Branch_Dept = int.Parse(User.GetClaimType("Branch_Departement"));
            var result = service.GET_CURRENT_SERVING(Branch_Dept);
            if (result.Status == false)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("GET_TOP_CURRENT_SERVING")]
        public ActionResult GET_TOP_CURRENT_SERVING()
        {
            var Branch_Dept = int.Parse(User.GetClaimType("Branch_Departement"));
            var result = service.GET_TOP_CURRENT_SERVING(Branch_Dept);
            if (result.Status == false)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("SERVE_TICKET")]
        public ActionResult SERVE_TICKET()
        {
            var Branch_Dept = int.Parse(User.GetClaimType("Branch_Departement"));
            var result = service.SERVE_TICKET(Branch_Dept);
            if (result.Status == false)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("DONE_TICKET")]
        public ActionResult DONE_TICKET([FromBody]DONE_TICKET_MODEL Ticket)
        {
            Ticket.Employee_Id = User.GetClaimType("Id");
            var result = service.DONE_TICKET(Ticket);
            if (result.Status == false)
                return BadRequest(result);
            return Ok(result);
        }
    }
}