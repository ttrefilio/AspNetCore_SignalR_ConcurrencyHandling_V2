using AutoMapper;
using TodoList.Application.DTOs;
using TodoList.Business.Entities;

namespace TodoList.Application.AutoMapper
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemDTO, Item>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsDone, opt => opt.MapFrom(src => src.IsDone))
                .ReverseMap();
        }
    }
}
