using _DB.Model.Ticket;
using System;
using System.Collections.Generic;
using System.Text;
using static _Service.Vw_Model.Notification.NOTIFICATION_MODEL;

namespace _Service.INTERFACES.GENERAL
{
    public interface INOTIFICATION_SERVICE
    {
        void Notifiy_New_Ticket(Ticket ticket);
        void Notifiy_New_Serving(Ticket ticket);
    }
}
