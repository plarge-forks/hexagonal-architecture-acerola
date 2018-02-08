﻿using Acerola.Application.DTO;
using Acerola.Domain.Customers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acerola.Infrastructure.AutoMapper
{
    public class CustomersProfile : Profile
    {
        public CustomersProfile()
        {
            CreateMap<Customer, CustomerData>()
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Personnummer, opt => opt.MapFrom(src => src.PIN.Text))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Text));
        }
    }
}
