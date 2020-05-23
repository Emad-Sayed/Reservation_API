using _Service.INTERFACES.GENERAL;
using _Service.Vw_Model.GENERAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static _Service.Vw_Model.TICKET.TICKET_MODEL;

namespace _Service.INTERFACES.TICKET
{
    public interface ITICKET_SERVICE
    {
        IREQUEST_RESULT GET_TICKETS(PAGINATION_MODEL Paging, int Branch_Dept);
        IREQUEST_RESULT GET_TICKET_BY_ID(int ID);
        IREQUEST_RESULT ADD_TICKET(ADD_TICKET_MODEL TICKET);
        IREQUEST_RESULT UPDATE_TICKET(UPDATE_TICKET_MODEL TICKET);
        IREQUEST_RESULT DELETE(int ID);
    }
}
