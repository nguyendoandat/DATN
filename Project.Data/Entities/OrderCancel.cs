using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class OrderCancel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
        public string Thumb { get; set; }
        public string Content { get; set; }

    }
}
