using System;
using System.Collections.Generic;
using System.Text;

namespace _Service.Vw_Model.REGISTERATION
{
    public class REGISTERATION_MODEL
    {
        public class ADD_REGISTERATION_MODEL
        {
            public int BRANCH_DEPARTEMENT_ID { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public bool EmailConfirmed { get; set; }
            public string Password { get; set; }
            public string Type__ { get; set; }
        }
    }
}
