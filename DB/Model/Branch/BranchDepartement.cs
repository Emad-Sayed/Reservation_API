using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _DB.Model.Branch
{
    public class BranchDepartement : BaseEntity
    {
        [ForeignKey("BRANCH")]
        public int BRANCH_ID { get; set; }
        [ForeignKey("DEPARTEMENT")]
        public int DEPARTEMENT_ID { get; set; }
        public Branch BRANCH { get; set; }
        public Departement DEPARTEMENT { get; set; }
    }
}
