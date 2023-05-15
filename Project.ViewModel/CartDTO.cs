using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class CartDTO
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }
        
        public string? UserId { get; set; }
        //    public Product Product { get; set; }
        //    public DateTime CreateAt { get; set; }
        public AppUser User { get; set; }
    }
}
