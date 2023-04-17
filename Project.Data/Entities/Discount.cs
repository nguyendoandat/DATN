using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Discount
    {
        public Discount()
        {
            Categories = new List<Category>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateAt { get; set; }
        public double DiscountPrice { get; set; }
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
