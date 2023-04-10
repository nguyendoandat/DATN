using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Promotion
    {
        public Promotion()
        {
            Products=new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateAt { get; set; }
        public int Discount { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
