using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class OrderDetailDTO
    {
        public int OrderID { set; get; }

        public int ProductID { set; get; }

        public int Quantity { set; get; }
        public decimal Price { get; set; }
        public Product Product { set; get; }
        public Order Order { get; set; }
    }
}
