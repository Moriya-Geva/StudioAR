using AutoMapper;
using Studio.Core.Entities;
using Studio.Core.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Studio.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<AudioSample, AudioSampleDTO>().ReverseMap();
            CreateMap<ChatMessage, ChatMessageDTO>().ReverseMap();
            CreateMap<ContactMessage, ContactMessageDTO>().ReverseMap();
            CreateMap<DeliverableFile, DeliverableFileDTO>().ReverseMap();
            CreateMap<FAQ, FAQDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<OrderFile, OrderFileDTO>().ReverseMap();
            CreateMap<OrderStatusHistory, OrderStatusHistoryDTO>().ReverseMap();
            CreateMap<SubCategory, SubCategoryDTO>().ReverseMap();
            CreateMap<SystemSetting, SystemSettingDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
