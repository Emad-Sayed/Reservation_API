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
                ticket.Created_Date = DateTime.Now;
                if (ticket.Ticket_Number == -1)
                {
                    var TimeOfNow = DateTime.Now.TimeOfDay;
                    var Config = context.Configuration.FirstOrDefault();
                    //CHECK IF HAS TICKET BEFORE
                    var SelectedTicket = context.Tickets.FirstOrDefault(t => t.Branch_Departement_Id == ticket.Branch_Departement_Id
                    && t.Client_Id == ticket.Client_Id && t.State_Id != 3 && t.Created_Date.Date == DateTime.Now.Date);
                    if (SelectedTicket != null)
                    {
                        request_result.Status = false;
                        request_result.Error_AR = "يوجد حجز مسبق في نفس اليوم";
                        request_result.Error_EN = "There is already already ticket Requested";
                        request_result.Data = SelectedTicket;
                        return request_result;
                    }
                    //CHECK IF During the Working Time
                    if (Config.Start_Reserving_Time > TimeOfNow || Config.End_Reserving_Time < TimeOfNow)
                    {
                        request_result.Status = false;
                        request_result.Error_AR = "لا يمكن الحجز في هذا الموعد";
                        request_result.Error_EN = "Time not available for Reservation";
                        request_result.Data = null;
                        return request_result;
                    }
                    var CurrentNumber = context.Tickets.Where(t => t.Branch_Departement_Id == ticket.Branch_Departement_Id
                        &&t.Created_Date.Date==DateTime.Now.Date)
                        .Select(t => t.Ticket_Number).DefaultIfEmpty(0).Max();
                    ticket.Ticket_Number = CurrentNumber + 1;
                    Ticket newTicket = mapper.Map<Ticket>(ticket);
                    newTicket.State_Id = 1;
                    context.Tickets.Add(newTicket);
                    context.SaveChanges();
                    notification_service.Notifiy_New_Ticket(newTicket);
                    request_result.Data = newTicket;
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
                var tickets = context.Tickets.Where(t => t.Branch_Departement_Id == Branch_Dept
                && t.Created_Date.Date == DateTime.Now.Date)
                    .OrderBy(t => t.Ticket_Number).Skip((Paging.Page_Number - 1) * Paging.Page_Size).Take(Paging.Page_Size).ToList();

                int TotalRows = context.Tickets.Where(t => t.Created_Date.Date == DateTime.Now.Date).Count();
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
