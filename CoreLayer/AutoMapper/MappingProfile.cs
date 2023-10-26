using AutoMapper;
using CoreLayer.Dtos.CategoryDtos;
using CoreLayer.Dtos.CustomerDtos;
using CoreLayer.Dtos.EstateDtos;
using CoreLayer.Dtos.EstateTypeDto;
using CoreLayer.Dtos.UserDtos;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AddCustomerDto, Customer>().ReverseMap();
            CreateMap<UpdateCustomerDto, Customer>().ReverseMap();

            CreateMap<AddCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();

            CreateMap<AddEstateDto, Estate>().ReverseMap();
            CreateMap<UpdateEstateDto, Estate>().ReverseMap();

            CreateMap<AddEstateTypeDto, EstateType>().ReverseMap();
            CreateMap<UpdateEstateTypeDto, EstateType>().ReverseMap();

            CreateMap<AddUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();


        }
    }
}
