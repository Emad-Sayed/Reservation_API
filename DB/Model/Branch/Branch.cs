using System;
using System.Collections.Generic;
using System.Text;

namespace _DB.Model.Branch
{
    public class Branch : BaseEntity
    {
        public string BRANCH_NAME { get; set; }
        public string BRANCH_ADDRESS { get; set; }
        public string BRANCH_PHONE { get; set; }
    }
}
