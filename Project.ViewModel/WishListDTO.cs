using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class WishListDTO
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public bool IsWishList { get; set; }
        public AppUser User { get; set; }
        public Product Product { get; set; }
    }
}
