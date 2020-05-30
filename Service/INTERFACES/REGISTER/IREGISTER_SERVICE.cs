using _Service.INTERFACES.GENERAL;
using _Service.Vw_Model.GENERAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static _Service.Vw_Model.REGISTERATION.REGISTERATION_MODEL;

namespace _Service.INTERFACES.REGISTER
{
    public interface IREGISTER_SERVICE 
    {
        Task<IREQUEST_RESULT> REGISTERATION(ADD_REGISTERATION_MODEL EMPLOYEE);
        IREQUEST_RESULT GET_USERS(PAGINATION_MODEL Paging);
    }
}
