using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _DB.Model.Branch
{
    public class BranchDepartement : BaseEntity
    {
        [ForeignKey("Branch")]
        public int Branch_Id { get; set; }
        [ForeignKey("Departement")]
        public int Departement_Id { get; set; }
        public Branch Branch { get; set; }
        public Departement Departement { get; set; }
    }
}
