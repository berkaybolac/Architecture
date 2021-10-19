using System.Linq;
using Entities.Dtos;
using Entities.Entities;

namespace Business.Abstract
{
    public interface IProductService
    {
        Products GetById(int id);
        IQueryable<ProductsDto> GetAll();
        void Insert(Products product);
        void Delete(int id);
        void Update(Products product);
    }
}
