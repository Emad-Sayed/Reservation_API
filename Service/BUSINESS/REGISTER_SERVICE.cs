using _Service.INTERFACES.GENERAL;
using _Service.INTERFACES.REGISTER;
using _Service.Vw_Model.REGISTERATION;
using AutoMapper;
using DB.Model.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static _Service.Vw_Model.REGISTERATION.REGISTERATION_MODEL;

namespace _Service.BUSINESS
{
    public class Register_Service : IREGISTER_SERVICE
    {
        private UserManager<AppUser> userManager;
        private IMapper mapper;
        private IREQUEST_RESULT request_result;
        public Register_Service(UserManager<AppUser> _userManager,IREQUEST_RESULT request_result_, IMapper mapper_)
        {
            userManager = _userManager;
            request_result = request_result_;
            mapper = mapper_;
        }
        public async Task<IREQUEST_RESULT> REGISTERATION(ADD_REGISTERATION_MODEL User)
        {
            try
            {
                //VALIDTION NOT NOW
                AppUser newAppUser = mapper.Map<AppUser>(User);
                var result = await userManager.CreateAsync(newAppUser, User.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newAppUser, User.Type__);
                }
                request_result.Data = newAppUser;
                return request_result;
            }
            catch (Exception ex)
            {
                request_result.Status = false;
                request_result.Error_AR = ex.Message + " : " + ex.Source;
                request_result.Error_EN = ex.Message + " : " + ex.Source;
                request_result.Data = null;
                return request_result;
            }
        }
    }
}
