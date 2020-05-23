using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _DB.Model.Branch
{
    public class Departement : BaseEntity
    {
        public string Departement_Name { get; set; }
    }
}
