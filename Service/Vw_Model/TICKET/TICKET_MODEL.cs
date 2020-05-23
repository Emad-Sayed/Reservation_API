using System;
using System.Collections.Generic;
using System.Text;

namespace _Service.Vw_Model.TICKET
{
    public class TICKET_MODEL
    {
        public class ADD_TICKET_MODEL
        {
            public DateTime CREATED_DATE { get; set; }
            public int TICKET_NUMBER { get; set; }
            public string CLIENT_ID { get; set; }
            public int BRANCH_DEPARTEMENT_ID { get; set; }
        }
        public class UPDATE_TICKET_MODEL
        {
        }
    }
}
