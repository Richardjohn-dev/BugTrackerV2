using AutoMapper;
using BugTracker.Application.DTOs.Project;
using BugTracker.Application.DTOs.TicketComment;
using BugTracker.Application.DTOs.TicketType;
using BugTracker.Domain.Entities;

namespace BugTracker.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<TicketType, TicketTypeDto>().ReverseMap();
            CreateMap<TicketStatus, TicketStatusDto>().ReverseMap();
            CreateMap<TicketPriority, TicketPriorityDto>().ReverseMap();
            CreateMap<TicketComment, TicketCommentDto>().ReverseMap();
            CreateMap<Project, ProjectDto>().ReverseMap();
        }
    }
}
