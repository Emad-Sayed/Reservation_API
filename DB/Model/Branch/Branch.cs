using System;
using System.Collections.Generic;
using System.Text;

namespace _DB.Model.Branch
{
    public class Branch : BaseEntity
    {
        public string Branch_Name_Ar { get; set; }
        public string Branch_Name_En { get; set; }
        public string Branch_Address { get; set; }
        public string Branch_Phone { get; set; }
    }
}
