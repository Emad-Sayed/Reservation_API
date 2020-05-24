using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Service.INTERFACES.GENERAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation_API.Helpers;
using static _Service.Vw_Model.Notification.NOTIFICATION_MODEL;

namespace Reservation_API.Controllers.Notification
{
    [Route("api/[controller]")]
    [ApiController]

    public class NotifyController : ControllerBase
    {
        private INOTIFICATION_SERVICE notification_service;
        public NotifyController(INOTIFICATION_SERVICE _notification_service)
        {
            notification_service = _notification_service;
        }
    }
}