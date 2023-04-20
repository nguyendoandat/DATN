using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
           
            Reviews = new HashSet<Reviews>();
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }

        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
