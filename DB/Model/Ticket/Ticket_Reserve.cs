using DB.Model.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _DB.Model.Ticket
{
    public class Ticket_Reserve : BaseEntity
    {
        [ForeignKey("Ticket")]
        public int Ticket_Id { get; set; }
        public Ticket Ticket { get; set; }
        [ForeignKey("Employee")]
        public string Employee_Id { get; set; }
        public AppUser Employee { get; set; }

    }
}
