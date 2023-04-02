using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class ImportProduct
    {
        public ImportProduct(){
           // Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ImportId { get; set; }
        public Import Import { get; set; }
        //public int ProductId { get; set; }
       // public ICollection<Product> Products { get; set; }    
    }
}
