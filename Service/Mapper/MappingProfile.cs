using _DB.Model.Ticket;
using AutoMapper;
using DB.Model.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using static _Service.Vw_Model.REGISTERATION.REGISTERATION_MODEL;
using static _Service.Vw_Model.TICKET.TICKET_MODEL;

namespace _Service.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ADD_REGISTERATION_MODEL, AppUser>();
            CreateMap<ADD_TICKET_MODEL, Ticket>();
        }
    }
}
