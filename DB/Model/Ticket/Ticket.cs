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
        public int Ticket_Number { get; set; }
        [ForeignKey("Client")]
        public string Client_Id { get; set; }
        public AppUser Client { get; set; }
        [ForeignKey("State")]
        public int State_Id { get; set; }
        public Ticket_State State { get; set; }
        [ForeignKey("Branch_Departement")]
        public int Branch_Departement_Id { get; set; }
        public BranchDepartement Branch_Departement { get; set; }
    }

}
