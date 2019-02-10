using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using Vidly.Models;
using Vidly.DTOs;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //domain to DTO
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
            Mapper.CreateMap<Customer, CustomerDTO>();

            //DTO to domain
            Mapper.CreateMap<CustomerDTO,Customer>()
                .ForMember(m => m.Id, opt => opt.Ignore()); ;
            
            Mapper.CreateMap<MovieDTO, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}