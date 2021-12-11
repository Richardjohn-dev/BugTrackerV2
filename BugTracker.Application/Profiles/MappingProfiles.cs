using AutoMapper;
using BugTracker.Application.DTOs.Project;
using BugTracker.Application.DTOs.Ticket;
using BugTracker.Application.DTOs.TicketComment;
using BugTracker.Application.DTOs.TicketPriority;
using BugTracker.Application.DTOs.TicketType;
using BugTracker.Application.DTOs.TicketStatus;
using BugTracker.Domain.Entities;

namespace BugTracker.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<TicketType, TicketTypeDto>().ReverseMap();
            CreateMap<TicketType, CreateTicketTypeDto>().ReverseMap();


            CreateMap<TicketStatus, TicketStatusDto>().ReverseMap();
            CreateMap<TicketStatus, CreateTicketStatusDto>().ReverseMap();

            CreateMap<TicketPriority, TicketPriorityDto>().ReverseMap();
            CreateMap<TicketPriority, CreateTicketPriorityDto>().ReverseMap();
           
            CreateMap<TicketComment, TicketCommentDto>().ReverseMap();
            CreateMap<TicketComment, CreateTicketCommentDto>().ReverseMap();
            
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<Project, CreateProjectDto>().ReverseMap();


            CreateMap<Ticket, TicketDto>().ReverseMap();
            CreateMap<Ticket, CreateTicketDto>().ReverseMap();

        }
    }
}
