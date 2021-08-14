using System.Collections.Generic;
using Entities.Concrete;

namespace Entities.Abstract.Entities
{
    public class Categories: IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}