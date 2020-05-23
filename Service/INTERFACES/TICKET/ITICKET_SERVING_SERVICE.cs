using _Service.INTERFACES.GENERAL;
using System;
using System.Collections.Generic;
using System.Text;
using static _Service.Vw_Model.TICKET.TICKET_MODEL;

namespace _Service.INTERFACES.TICKET
{
    public interface ITICKET_SERVING_SERVICE
    {
        IREQUEST_RESULT GET_CURRENT_SERVING(int Branch_Dept);
        IREQUEST_RESULT GET_TOP_CURRENT_SERVING(int Branch_Dept);
        IREQUEST_RESULT SERVE_TICKET(int Branch_Dept);
        IREQUEST_RESULT DONE_TICKET(DONE_TICKET_MODEL model);

    }
}
