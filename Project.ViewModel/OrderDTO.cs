using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? UserId { get; set; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public int StatusId { get; set; }
        public string? ShipperId { get; set; }
        public Status Status { get; set; }
        public AppUser? User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
