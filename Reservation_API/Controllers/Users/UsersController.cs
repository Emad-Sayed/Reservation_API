using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Service.INTERFACES.REGISTER;
using _Service.Vw_Model.GENERAL;
using DB.Model.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static _Service.Vw_Model.REGISTERATION.REGISTERATION_MODEL;

namespace Reservation_API.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles="admin")]
    public class UsersController : ControllerBase
    {
        private IREGISTER_SERVICE service;
        public UsersController(IREGISTER_SERVICE _service)
        {
            service = _service;
        }
        [HttpPost]
        public async Task<IActionResult> Add_Employee([FromBody]ADD_REGISTERATION_MODEL employee)
        {
            var result = await service.REGISTERATION(employee);
            if (result.Status == false)
                return BadRequest(result);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost("REGISTERATION")]
        public async Task<IActionResult> REGISTERATION([FromBody]ADD_REGISTERATION_MODEL client)
        {
            client.Type__ = "client";
            client.EmailConfirmed = false;
            var result = await service.REGISTERATION(client);
            if (result.Status == false)
                return BadRequest(result);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpGet]
        public  IActionResult GET_USERS([FromBody]PAGINATION_MODEL Page)
        {
            var result = service.GET_USERS(Page);
            if (result.Status == false)
                return BadRequest(result);
            return Ok(result);
        }
    }
}