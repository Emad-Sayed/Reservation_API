using _Service.INTERFACES.GENERAL;
using _Service.INTERFACES.REGISTER;
using _Service.Vw_Model.GENERAL;
using _Service.Vw_Model.REGISTERATION;
using AutoMapper;
using DB.Context;
using DB.Model.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static _Service.Vw_Model.REGISTERATION.REGISTERATION_MODEL;

namespace _Service.BUSINESS
{
    public class Register_Service : IREGISTER_SERVICE
    {
        private UserManager<AppUser> userManager;
        private AppDbContext context;
        private IMapper mapper;
        private IREQUEST_RESULT request_result;
        public Register_Service(UserManager<AppUser> _userManager, AppDbContext context_, IREQUEST_RESULT request_result_, IMapper mapper_)
        {
            userManager = _userManager;
            context = context_;
            request_result = request_result_;
            mapper = mapper_;
        }

        public IREQUEST_RESULT GET_USERS(PAGINATION_MODEL Paging)
        {
            try
            {
                var users = context.VwUsers.Skip((Paging.Page_Number - 1) * Paging.Page_Size).Take(Paging.Page_Size).ToList();
                int TotalRows = context.VwUsers.Count();
                if (users.Count == 0)
                {
                    request_result.Status = false;
                    request_result.Error_AR = "لا يوجد بيانات";
                    request_result.Error_EN = "There are no data";
                    request_result.Data = null;
                    return request_result;
                }
                request_result.Status = true;
                request_result.Pages_Total_Rows = TotalRows;
                float all_pages = (float)TotalRows / Paging.Page_Size;
                request_result.Pages_Number = (int)Math.Ceiling(all_pages);
                request_result.Page_Size = Paging.Page_Size;
                request_result.Page_Number = Paging.Page_Number;
                request_result.Data = users;
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
