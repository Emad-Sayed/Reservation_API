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
using static _Service.Vw_Model.TICKET.TICKET_MODEL;
using AutoMapper;
using _DB.Model.Ticket;

namespace _Service.BUSINESS
{
    public class Ticket_Service : ITICKET_SERVICE
    {
        private AppDbContext context;
        private IMapper mapper;
        private IREQUEST_RESULT request_result;
        private INOTIFICATION_SERVICE notification_service;
        public Ticket_Service(AppDbContext context_, IMapper _mapper, INOTIFICATION_SERVICE _notification_service, IREQUEST_RESULT request_result_)
        {
            context = context_;
            mapper = _mapper;
            notification_service = _notification_service;
            request_result = request_result_;
        }
        public IREQUEST_RESULT ADD_TICKET(ADD_TICKET_MODEL ticket)
        {
            try
            {
                ticket.CREATED_DATE = DateTime.Now;
                if (ticket.TICKET_NUMBER == -1)
                {
                    var TimeOfNow = DateTime.Now.TimeOfDay;
                    var Config = context.Configuration.FirstOrDefault();
                    //CHECK IF During the Working Time
                    if(Config.START_RESERVING_TIME > TimeOfNow || Config.END_RESERVING_TIME < TimeOfNow)
                    {
                        request_result.Status = false;
                        request_result.Error_AR = "لا يمكن الحجز في هذا الموعد";
                        request_result.Error_EN = "Time not available for Reservation";
                        request_result.Data = null;
                        return request_result;
                    }
                    var CurrentNumber = context.Tickets.Where(t=>t.BRANCH_DEPARTEMENT_ID == ticket.BRANCH_DEPARTEMENT_ID)
                        .Select(t=>t.TICKET_NUMBER).DefaultIfEmpty(0).Max();
                    ticket.TICKET_NUMBER = CurrentNumber + 1;
                    Ticket newTicket = mapper.Map<Ticket>(ticket);
                    newTicket.STATE_ID = 1;
                    context.Tickets.Add(newTicket);
                    context.SaveChanges();
                    notification_service.Notifiy_New_Ticket(newTicket);
                }
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

        public IREQUEST_RESULT DELETE(int ID)
        {
            try
            {

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

        public IREQUEST_RESULT GET_TICKETS(PAGINATION_MODEL Paging, int Branch_Dept)
        {
            try
            {
                var tickets = context.Tickets.Where(t => t.BRANCH_DEPARTEMENT_ID == Branch_Dept
                && t.CREATED_DATE.Date == DateTime.Now.Date)
                    .OrderBy(t => t.TICKET_NUMBER).Skip((Paging.Page_Number - 1) * Paging.Page_Size).Take(Paging.Page_Size).ToList();

                int TotalRows = context.Tickets.Where(t => t.CREATED_DATE.Date == DateTime.Now.Date).Count();
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
            catch (Exception ex)
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
