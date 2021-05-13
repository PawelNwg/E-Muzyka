using AutoMapper;
using E_Muzyka.ModelDTO;
using E_Muzyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.MappingConfig
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Album, AlbumDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.AppUser.Name))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(x => x.AppUser.Surname));
            CreateMap<Track, TrackDTO>()
                .ForMember(dest => dest.AlbumTitle, opt => opt.MapFrom(x => x.Album.Title));
        }
    }
}