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
            Categorys = new HashSet<Category>();
            Reviews = new HashSet<Reviews>();
        }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public ICollection<Category> Categorys { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
    }
}
