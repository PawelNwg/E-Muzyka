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
            CreateMap<Album, AlbumDTO>().ReverseMap();
            CreateMap<Track, TrackDTO>().ReverseMap();
        }
    }
}