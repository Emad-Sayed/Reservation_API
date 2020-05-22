using _Service.INTERFACES.GENERAL;
using _Service.INTERFACES.TICKET;
using _Service.Vw_Model.GENERAL;
using _Service.Vw_Model.TICKET;
using DB.Context;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _Service.BUSINESS
{
    public class Ticket_Service : ITICKET_SERVICE
    {
        private AppDbContext context;
        private IREQUEST_RESULT request_result;
        public Ticket_Service(AppDbContext context_, IREQUEST_RESULT request_result_)
        {
            context = context_;
            request_result = request_result_;
        }
        public IREQUEST_RESULT ADD_TICKET(TICKET_MODEL.ADD_TICKET_MODEL TICKET)
        {
            throw new NotImplementedException();
        }

        public IREQUEST_RESULT DELETE(int ID)
        {
            throw new NotImplementedException();
        }

        public IREQUEST_RESULT GET_TICKETS(PAGINATION_MODEL Paging)
        {
            try
            {
                var tickets = context.TICKETS.Where(t => t.CREATED_DATE.Date == DateTime.Now.Date)
                    .OrderBy(t => t.TICKET_NUMBER).Skip((Paging.Page_Number - 1) * Paging.Page_Size).Take(Paging.Page_Size).ToList();

                int TotalRows = context.TICKETS.Where(t => t.CREATED_DATE.Date == DateTime.Now.Date).Count();
                if (tickets.Count == 0)
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
                request_result.Data = tickets;
                return request_result;
            }
            catch(Exception ex)
            {
                request_result.Status = false;
                request_result.Error_AR = ex.Message + " : " + ex.Source;
                request_result.Error_EN = ex.Message + " : " + ex.Source;
                request_result.Data = null;
                return request_result;
            }
        }

        public IREQUEST_RESULT GET_TICKET_BY_ID(int ID)
        {
            throw new NotImplementedException();
        }

        public IREQUEST_RESULT UPDATE_TICKET(TICKET_MODEL.UPDATE_TICKET_MODEL TICKET)
        {
            throw new NotImplementedException();
        }
    }
}
