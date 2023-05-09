using Microsoft.AspNetCore.Http;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Slug { get; set; }
        public int Quantity { get; set; }
        public string? Size { get; set; }
        public string ProductDetail { get; set; }
        public decimal Price { get; set; }
       // public bool Trend { get; set; }
        public bool Status { get; set; }
        //public int View { get; set; }
        public string Thumb { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } 
      
     
        public List<Category> ListCategory { get; set; }
        public IFormFile File { get; set; }
    }
}
