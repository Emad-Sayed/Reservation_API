using System;
using System.Collections.Generic;
using System.Text;

namespace _Service.Vw_Model.TICKET
{
    public class TICKET_MODEL
    {
        public class ADD_TICKET_MODEL
        {
            public DateTime Created_Date { get; set; }
            public int Ticket_Number { get; set; }
            public string Client_Id { get; set; }
            public int Branch_Departement_Id { get; set; }
        }
        public class UPDATE_TICKET_MODEL
        {
        }
        public class DONE_TICKET_MODEL
        {
            public int Id { get; set; }
            public string Employee_Id { get; set; }
        }
    }
}
