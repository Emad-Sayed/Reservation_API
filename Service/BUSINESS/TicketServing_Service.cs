using _Service.INTERFACES.GENERAL;
using _Service.INTERFACES.TICKET;
using AutoMapper;
using DB.Context;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using _Service.Vw_Model.TICKET;
using static _Service.Vw_Model.TICKET.TICKET_MODEL;
using _DB.Model.Ticket;

namespace _Service.BUSINESS
{
    public class TicketServing_Service : ITICKET_SERVING_SERVICE
    {
        private AppDbContext context;
        private IMapper mapper;
        private IREQUEST_RESULT request_result;
        private INOTIFICATION_SERVICE notification_service;
        public TicketServing_Service(AppDbContext context_, IMapper _mapper, INOTIFICATION_SERVICE _notification_service, IREQUEST_RESULT request_result_)
        {
            context = context_;
            mapper = _mapper;
            notification_service = _notification_service;
            request_result = request_result_;
        }

        public IREQUEST_RESULT DONE_TICKET(DONE_TICKET_MODEL model)
        {
            try
            {
                var SelectedTicket = context.Tickets.Where(t => t.Id == model.Id).SingleOrDefault();
                if (SelectedTicket == null || SelectedTicket.State_Id != 2)
                {
                    request_result.Status = false;
                    request_result.Error_AR = "لا يوجد بيانات";
                    request_result.Error_EN = "There are no data";
                    request_result.Data = null;
                    return request_result;
                }
                SelectedTicket.State_Id = 3;
                Ticket_Reserve TS = new Ticket_Reserve
                {
                    Ticket_Id = model.Id,
                    Employee_Id = model.Employee_Id,
                    Created_Date = DateTime.Now
                };
                request_result.Data = SelectedTicket;
                context.Ticket_Reserves.Add(TS);
                context.SaveChanges();
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

        public IREQUEST_RESULT GET_CURRENT_SERVING(int Branch_Dept)
        {
            try
            {
                var Pending = context.Tickets.Where(t => t.Branch_Departement_Id == Branch_Dept
                && t.Created_Date.Date == DateTime.Now.Date && t.State_Id == 2).ToList();
                if (Pending.Count == 0)
                {
                    request_result.Status = false;
                    request_result.Error_AR = "لا يوجد بيانات";
                    request_result.Error_EN = "There are no data";
                    request_result.Data = null;
                    return request_result;
                }
                request_result.Data = Pending;
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

        public IREQUEST_RESULT GET_TOP_CURRENT_SERVING(int Branch_Dept)
        {
            try
            {
                var TopPending = context.Tickets.Where(t => t.Branch_Departement_Id == Branch_Dept &&
                t.Created_Date.Date == DateTime.Now.Date && t.State_Id == 2).OrderByDescending(t => t.Id).FirstOrDefault();
                if (TopPending == null)
                {
                    request_result.Status = false;
                    request_result.Error_AR = "لا يوجد بيانات";
                    request_result.Error_EN = "There are no data";
                    request_result.Data = null;
                    return request_result;
                }
                request_result.Data = TopPending;
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

        public IREQUEST_RESULT SERVE_TICKET(int Branch_Dept)
        {
            try
            {
                var Waiting = context.Tickets.Where(t => t.Branch_Departement_Id == Branch_Dept &&
                t.Created_Date.Date == DateTime.Now.Date && t.State_Id == 1).OrderBy(t => t.Ticket_Number).FirstOrDefault();
                if (Waiting == null)
                {
                    request_result.Status = false;
                    request_result.Error_AR = "لا يوجد بيانات";
                    request_result.Error_EN = "There are no data";
                    request_result.Data = null;
                    return request_result;
                }
                Waiting.State_Id = 2;
                Waiting.Last_Update = DateTime.Now;
                context.SaveChanges();
                request_result.Data = Waiting;
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
