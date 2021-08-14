using Entities.Concrete;

namespace Entities.Abstract.Entities
{
    public class Products: IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public char QuantityPerUnit { get; set; }
        public float UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public byte Discontinued { get; set; }
        public Categories Category { get; set; }
    }
}
