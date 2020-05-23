using _DB.Model.Branch;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Model.Auth
{
    public class AppUser : IdentityUser
    {
        public string Confirmation_Code { get; set; }
        [ForeignKey("BRANCH_DEPARTEMENT")]
        public int BRANCH_DEPARTEMENT_ID { get; set; }
        public BranchDepartement BRANCH_DEPARTEMENT { get; set; }
    }
}
