using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            //Discounts=new HashSet<Discount>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        //public string Slug { get; set; }
        //public bool Trend { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        //public ICollection<Discount> Discounts { get; set; }
        //public string UserId { get; set; }
        //public AppUser User { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
