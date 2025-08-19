using App_Anime.model;
using App_Anime.ViewModel;
using AutoMapper;


namespace App_Anime.Mapping
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<Teacher, TeacherVm>()
                .ForMember(dest => dest.ProfilePicture, opt => opt.MapFrom(src => src.Img))
                .ForMember(dest => dest.ExperienceYears, opt => opt.MapFrom(src => src.Experience))
                .ForMember(dest => dest.Designation, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
