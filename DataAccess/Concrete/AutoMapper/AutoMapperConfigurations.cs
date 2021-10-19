using AutoMapper;
using Entities.Dtos;
using Entities.Entities;

namespace DataAccess.Concrete.AutoMapper
{
    public class AutoMapperConfigurations : Profile
    {
        public AutoMapperConfigurations()
        {
            CreateMap<Products, ProductsDto>();
        }
    }
}