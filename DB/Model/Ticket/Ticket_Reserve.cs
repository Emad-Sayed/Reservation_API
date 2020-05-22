using DB.Model.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _DB.Model.Ticket
{
    public class Ticket_Reserve : BaseEntity
    {
        [ForeignKey("TICKET")]
        public int TICKET_ID { get; set; }
        public Ticket TICKET { get; set; }
        [ForeignKey("EMPLOYEE")]
        public string EMPLOYEE_ID { get; set; }
        public AppUser EMPLOYEE { get; set; }

    }
}
