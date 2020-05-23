using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _DB.Model.Branch
{
    public class Departement : BaseEntity
    {
        public string DEPARTEMENT_NAME { get; set; }
    }
}
