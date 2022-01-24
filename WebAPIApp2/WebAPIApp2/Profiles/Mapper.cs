using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp2.Data.Entities;
using WebAPIApp2.DTOs;

namespace WebAPIApp2.Profiles
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Product, ProductGetDto>();
            CreateMap<ProductPostDto, Product>();
        }
    }
}
