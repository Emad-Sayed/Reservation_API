using System;
using System.Collections.Generic;
using System.Text;

namespace _Service.INTERFACES.GENERAL
{
    public interface IREQUEST_RESULT
    {
        bool Status { get; set; }
        string Error_AR { get; set; }
        string Error_EN { get; set; }
        int Page_Size { get; set; }
        int Page_Number { get; set; }
        int Pages_Number { get; set; }
        int Pages_Total_Rows { get; set; }
        object Data { get; set; }
    }
}
