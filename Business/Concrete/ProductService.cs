using System.Linq;
using AutoMapper;
using Business.Abstract;
using DataAccess;
using Entities.Dtos;
using Entities.Entities;

namespace Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly NorthwindDbContext _productRepository;
        private readonly IMapper _mapper;
        public ProductService(NorthwindDbContext productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Products GetById(int id)
        {
            return _productRepository.Products.FirstOrDefault(p => p.ProductID == id);
        }

        public IQueryable<ProductsDto> GetAll()
        {
            return _mapper.ProjectTo<ProductsDto>(_productRepository.Products.AsQueryable());
        }

        public void Insert(Products product)
        {
            _productRepository.Products.Add(product);
        }

        public void Delete(int id)
        {
            var onDeleting = _productRepository.Products.FirstOrDefault(p => p.ProductID == id);
            _productRepository.Products.Remove(onDeleting);
        }

        public void Update(Products product)
        {
           _productRepository.Products.Update(product);
        }
    }
}