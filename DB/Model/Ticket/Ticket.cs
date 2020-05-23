using _DB.Model.Branch;
using DB.Model.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _DB.Model.Ticket
{
    public class Ticket : BaseEntity
    {
        public int TICKET_NUMBER { get; set; }
        [ForeignKey("CLIENT")]
        public string CLIENT_ID { get; set; }
        public AppUser CLIENT { get; set; }
        [ForeignKey("STATE")]
        public int STATE_ID { get; set; }
        public Ticket_State STATE { get; set; }
        [ForeignKey("BRANCH_DEPARTEMENT")]
        public int BRANCH_DEPARTEMENT_ID { get; set; }
        public BranchDepartement BRANCH_DEPARTEMENT { get; set; }
    }

}
