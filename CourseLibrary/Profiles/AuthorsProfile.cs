using AutoMapper;
using CourseLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.Profiles
{
    public class AuthorsProfile : Profile
    {

        public AuthorsProfile()
        {
            CreateMap<API.Entities.Author, Models.AuthorDto>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"
                    )
                )
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()
                    )
                );

            CreateMap<Models.AuthorForCreationDto, API.Entities.Author>();
        }
    }
}
