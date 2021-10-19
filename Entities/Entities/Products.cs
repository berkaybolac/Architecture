using AutoMapper;
using Entities.Dtos;
using Entities.Interfaces;

namespace Entities.Entities
{
    [AutoMap(typeof(ProductsDto))]
    public class Products: IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public char QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public Categories Category { get; set; }
    }
}
