using _Service.INTERFACES.GENERAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Service.Vw_Model.GENERAL
{
    public class REQUEST_RESULT : IREQUEST_RESULT
    {
        public REQUEST_RESULT()
        {
            Status = true;
        }
        public bool Status { get; set; }
        public string Error_AR { get; set; }
        public string Error_EN { get; set; }
        public int Page_Size { get; set; }
        public int Page_Number { get; set; }
        public int Pages_Number { get; set; }
        public int Pages_Total_Rows { get; set; }
        public object Data { get; set; }
    }
}
